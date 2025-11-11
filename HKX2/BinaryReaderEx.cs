using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace HKX2E;

public class BinaryReaderEx
{
    private readonly Stack<long> steps;
    private readonly BinaryReader br;

    public BinaryReaderEx(byte[] input)
        : this(false, false, new MemoryStream(input)) { }

    public BinaryReaderEx(Stream stream)
        : this(false, false, stream) { }

    public BinaryReaderEx(bool bigEndian, bool uSizeLong, byte[] input)
        : this(bigEndian, uSizeLong, new MemoryStream(input)) { }

    public BinaryReaderEx(bool bigEndian, bool uSizeLong, Stream stream)
    {
        BigEndian = bigEndian;
        USizeLong = uSizeLong;
        Stream = stream ?? throw new ArgumentNullException(nameof(stream));

        br = new BinaryReader(stream, Encoding.ASCII, leaveOpen: true);
        steps = new Stack<long>();
    }

    public bool BigEndian { get; set; }
    public bool USizeLong { get; }
    public Stream Stream { get; }

    public long Position
    {
        get => Stream.Position;
        set => Stream.Position = value;
    }
    public long Length => Stream.Length;

    public byte[] ReadBytes(int count)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(count);
        if (count == 0)
            return Array.Empty<byte>();

        var buffer = new byte[count];
        Stream.ReadExactly(buffer);
        return buffer;
    }

    public void StepIn(long offset)
    {
        steps.Push(Stream.Position);
        Stream.Position = offset;
    }

    public void StepOut()
    {
        if (steps.Count == 0)
            throw new InvalidOperationException("Reader is already stepped all the way out.");
        Stream.Position = steps.Pop();
    }

    public void Pad(int align)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(align);

        long mod = Stream.Position % align;
        if (mod > 0)
            Stream.Position += align - mod;
    }

    private static T AssertValue<T>(T value, string typeName, string valueFormat, T[] options)
        where T : IEquatable<T>
    {
        foreach (var option in options)
            if (value.Equals(option))
                return value;
        var strValue = string.Format(valueFormat, value);
        var strOptions = string.Join(", ", options.Select(o => string.Format(valueFormat, o)));

        throw new InvalidDataException($"Read {typeName}: {strValue} | Expected: {strOptions}");
    }

    #region Read Methods

    public bool ReadBoolean() => br.ReadBoolean();

    public byte ReadByte() => br.ReadByte();

    public sbyte ReadSByte() => br.ReadSByte();

    public short ReadInt16()
    {
        if (!BigEndian)
        {
            return br.ReadInt16();
        }
        else
        {
            Span<byte> buf = stackalloc byte[2];
            Stream.ReadExactly(buf);
            return BinaryPrimitives.ReadInt16BigEndian(buf);
        }
    }

    public ushort ReadUInt16()
    {
        if (!BigEndian)
        {
            return br.ReadUInt16();
        }
        else
        {
            Span<byte> buf = stackalloc byte[2];
            Stream.ReadExactly(buf);
            return BinaryPrimitives.ReadUInt16BigEndian(buf);
        }
    }

    public int ReadInt32()
    {
        if (!BigEndian)
        {
            return br.ReadInt32();
        }
        else
        {
            Span<byte> buf = stackalloc byte[4];
            Stream.ReadExactly(buf);
            return BinaryPrimitives.ReadInt32BigEndian(buf);
        }
    }

    public uint ReadUInt32()
    {
        if (!BigEndian)
        {
            return br.ReadUInt32();
        }
        else
        {
            Span<byte> buf = stackalloc byte[4];
            Stream.ReadExactly(buf);
            return BinaryPrimitives.ReadUInt32BigEndian(buf);
        }
    }

    public long ReadInt64()
    {
        if (!BigEndian)
        {
            return br.ReadInt64();
        }
        else
        {
            Span<byte> buf = stackalloc byte[8];
            Stream.ReadExactly(buf);
            return BinaryPrimitives.ReadInt64BigEndian(buf);
        }
    }

    public ulong ReadUInt64()
    {
        if (!BigEndian)
        {
            return br.ReadUInt64();
        }
        else
        {
            Span<byte> buf = stackalloc byte[8];
            Stream.ReadExactly(buf);
            return BinaryPrimitives.ReadUInt64BigEndian(buf);
        }
    }

    public ulong ReadUSize() => USizeLong ? ReadUInt64() : ReadUInt32();

    public Half ReadHalf()
    {
        /// NOTE: C++'s `hkHalf` is the upper 16 bits of `float` and does not follow IEEE 754.
        /// However, this library has already been designed using `System.Half`, so it is necessary not to break compatibility.
        /// Therefore, we should do `bytes` -> `float` -> `half` here to keep compatibility.
        ushort halfBits;

        if (!BigEndian)
        {
            halfBits = br.ReadUInt16();
        }
        else
        {
            Span<byte> buf = stackalloc byte[2];
            Stream.ReadExactly(buf);
            halfBits = BinaryPrimitives.ReadUInt16BigEndian(buf);
        }

        float floatValue = BitConverter.UInt32BitsToSingle((uint)halfBits << 16);
        return (Half)floatValue;
    }

    public float ReadSingle()
    {
        float val;

        if (!BigEndian)
        {
            val = br.ReadSingle();
        }
        else
        {
            Span<byte> buf = stackalloc byte[4];
            Stream.ReadExactly(buf);
            val = BinaryPrimitives.ReadSingleBigEndian(buf);
        }

        // XXX: NaN(0xFFC0000) to 0.
        if (float.IsNaN(val))
            return 0f;

        // XXX: round? to 6 decimal
        return (float)Math.Round(val, 6);
    }

    public double ReadDouble()
    {
        if (!BigEndian)
        {
            return br.ReadDouble();
        }
        else
        {
            Span<byte> buf = stackalloc byte[8];
            Stream.ReadExactly(buf);
            return BinaryPrimitives.ReadDoubleBigEndian(buf);
        }
    }

    private string ReadChars(Encoding encoding, int length)
    {
        if (length <= 0)
            return string.Empty;
        byte[] rented = ArrayPool<byte>.Shared.Rent(length);
        try
        {
            var span = rented.AsSpan(0, length);
            Stream.ReadExactly(span);
            return encoding.GetString(span);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(rented);
        }
    }

    private string ReadCharsTerminated(Encoding encoding)
    {
        var bytes = new List<byte>();
        int b;
        while ((b = Stream.ReadByte()) != 0 && b != -1)
        {
            bytes.Add((byte)b);
        }
        return encoding.GetString(bytes.ToArray());
    }

    public string ReadASCII() => ReadCharsTerminated(Encoding.ASCII);

    public string ReadASCII(int length) => ReadChars(Encoding.ASCII, length);

    public string ReadFixStr(int size)
    {
        if (size <= 0)
            return string.Empty;
        byte[] rented = ArrayPool<byte>.Shared.Rent(size);
        try
        {
            var span = rented.AsSpan(0, size);
            Stream.ReadExactly(span);
            int term = span.IndexOf((byte)0);
            int len = term >= 0 ? term : size;
            return Encoding.ASCII.GetString(span.Slice(0, len));
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(rented);
        }
    }

    public Vector4 ReadVector4()
    {
        var x = ReadSingle();
        var y = ReadSingle();
        var z = ReadSingle();
        var w = ReadSingle();
        return new Vector4(x, y, z, w);
    }

    #endregion

    #region Assert Methods

    public ulong AssertUSize(params ulong[] options) =>
        AssertValue(ReadUSize(), USizeLong ? "USize64" : "USize32", "0x{0:X}", options);

    public bool AssertBoolean(bool option) =>
        AssertValue(ReadBoolean(), "Boolean", "{0}", [option]);

    public sbyte AssertSByte(params sbyte[] options) =>
        AssertValue(ReadSByte(), "SByte", "0x{0:X}", options);

    public byte AssertByte(params byte[] options) =>
        AssertValue(ReadByte(), "Byte", "0x{0:X}", options);

    public short AssertInt16(params short[] options) =>
        AssertValue(ReadInt16(), "Int16", "0x{0:X}", options);

    public ushort AssertUInt16(params ushort[] options) =>
        AssertValue(ReadUInt16(), "UInt16", "0x{0:X}", options);

    public int AssertInt32(params int[] options) =>
        AssertValue(ReadInt32(), "Int32", "0x{0:X}", options);

    public uint AssertUInt32(params uint[] options) =>
        AssertValue(ReadUInt32(), "UInt32", "0x{0:X}", options);

    public long AssertInt64(params long[] options) =>
        AssertValue(ReadInt64(), "Int64", "0x{0:X}", options);

    public ulong AssertUInt64(params ulong[] options) =>
        AssertValue(ReadUInt64(), "UInt64", "0x{0:X}", options);

    public Half AssertHalf(params Half[] options) =>
        AssertValue(ReadHalf(), "Half", "{0}", options);

    public float AssertSingle(params float[] options) =>
        AssertValue(ReadSingle(), "Single", "{0}", options);

    public double AssertDouble(params double[] options) =>
        AssertValue(ReadDouble(), "Double", "{0}", options);

    #endregion
}
