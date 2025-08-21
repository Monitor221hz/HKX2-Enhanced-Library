using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text;

namespace HKX2E;

public class BinaryWriterEx
{
    public readonly BinaryWriter bw;
    private readonly Dictionary<string, long> reservations;
    private readonly Stack<long> steps;

    public BinaryWriterEx() : this(false, false) { }
    public BinaryWriterEx(Stream stream) : this(false, false, stream) { }
    public BinaryWriterEx(bool bigEndian, bool uSizeLong) : this(bigEndian, uSizeLong, new MemoryStream()) { }

    public BinaryWriterEx(bool bigEndian, bool uSizeLong, Stream stream)
    {
        BigEndian = bigEndian;
        USizeLong = uSizeLong;
        steps = new Stack<long>();
        reservations = new Dictionary<string, long>();
        Stream = stream;
        bw = new BinaryWriter(stream);
    }

    public bool BigEndian { get; set; }
    private bool USizeLong { get; }
    public Stream Stream { get; }

    public long Position
    {
        get => Stream.Position;
        set => Stream.Position = value;
    }

    public long Length => Stream.Length;


    private void Reserve(string name, string typeName, int length)
    {
        name = $"{name}:{typeName}";
        if (reservations.ContainsKey(name))
            throw new ArgumentException("Key already reserved: " + name);

        reservations[name] = Stream.Position;

        for (var i = 0; i < length; i++)
            bw.Write((byte)0xFE);
    }

    private long Fill(string name, string typeName)
    {
        name = $"{name}:{typeName}";
        if (!reservations.TryGetValue(name, out var jump))
            throw new ArgumentException("Key is not reserved: " + name);

        reservations.Remove(name);
        return jump;
    }

    public void StepIn(long offset)
    {
        steps.Push(Stream.Position);
        Stream.Position = offset;
    }
    public void StepOut()
    {
        if (steps.Count == 0)
            throw new InvalidOperationException("Writer is already stepped all the way out.");

        Stream.Position = steps.Pop();
    }

    public void Pad(int align)
    {
        while (Stream.Position % align > 0)
            WriteByte(0);
    }


    #region Write

    public void WriteBytes(byte[] value) => bw.Write(value);
    public void WriteByte(byte value) => bw.Write(value);
    public void WriteSByte(sbyte value) => bw.Write(value);
    public void WriteBoolean(bool value) => bw.Write(value);

    public void WriteInt16(short value)
    {
        if (!BigEndian)
        {
            bw.Write(value);
            return;
        }
        Span<byte> buffer = stackalloc byte[2];
        BinaryPrimitives.WriteInt16BigEndian(buffer, value);
        bw.Write(buffer);
    }
    public void WriteInt32(int value)
    {
        if (!BigEndian)
        {
            bw.Write(value);
            return;
        }
        Span<byte> buffer = stackalloc byte[4];
        BinaryPrimitives.WriteInt32BigEndian(buffer, value);
        bw.Write(buffer);
    }
    public void WriteInt64(long value)
    {
        if (!BigEndian)
        {
            bw.Write(value);
            return;
        }
        Span<byte> buffer = stackalloc byte[8];
        BinaryPrimitives.WriteInt64BigEndian(buffer, value);
        bw.Write(buffer);
    }


    public void WriteUInt16(ushort value)
    {
        if (!BigEndian)
        {
            bw.Write(value);
            return;
        }
        Span<byte> buffer = stackalloc byte[2];
        BinaryPrimitives.WriteUInt16BigEndian(buffer, value);
        bw.Write(buffer);
    }
    public void WriteUInt32(uint value)
    {
        if (!BigEndian)
        {
            bw.Write(value);
            return;
        }
        Span<byte> buffer = stackalloc byte[4];
        BinaryPrimitives.WriteUInt32BigEndian(buffer, value);
        bw.Write(buffer);
    }
    public void WriteUInt64(ulong value)
    {
        if (!BigEndian)
        {
            bw.Write(value);
            return;
        }
        Span<byte> buffer = stackalloc byte[8];
        BinaryPrimitives.WriteUInt64BigEndian(buffer, value);
        bw.Write(buffer);
    }

    public void WriteUSize(ulong value)
    {
        if (USizeLong)
            WriteUInt64(value);
        else
            WriteUInt32((uint)value);
    }

    public void WriteHalf(Half value)
    {
        /// NOTE: C++'s `hkHalf` is the upper 16 bits of `float` and does not follow IEEE754.
        /// However, this library has already been designed using `System.Half`, so it is necessary not to break compatibility.
        /// Therefore, we should do `half` -> `float` -> `bytes` here to keep compatibility.
        uint bits = BitConverter.SingleToUInt32Bits((float)value);
        ushort halfBits = (ushort)(bits >> 16); // Only the most significant 16 bits are taken out.
        WriteUInt16(halfBits);
    }
    public void WriteSingle(float value)
    {
        if (!BigEndian)
        {
            bw.Write(value);
            return;
        }
        Span<byte> buffer = stackalloc byte[4];
        BinaryPrimitives.WriteSingleBigEndian(buffer, value);
        bw.Write(buffer);
    }
    public void WriteDouble(double value)
    {
        if (!BigEndian)
        {
            bw.Write(value);
            return;
        }
        Span<byte> buffer = stackalloc byte[8];
        BinaryPrimitives.WriteDoubleBigEndian(buffer, value);
        bw.Write(buffer);
    }

    public void WriteVector4(Vector4 vector)
    {
        WriteSingle(vector.X);
        WriteSingle(vector.Y);
        WriteSingle(vector.Z);
        WriteSingle(vector.W);
    }

    private void WriteChars(string text, Encoding encoding, bool terminate)
    {
        if (terminate)
            text += '\0';
        var value = encoding.GetBytes(text);
        bw.Write(value);
    }

    public void WriteASCII(string text, bool terminate = false) => WriteChars(text, Encoding.ASCII, terminate);

    public void WriteFixStr(string text, int size, byte padding = 0)
    {
        var value = new byte[size];
        for (var i = 0; i < size; i++)
            value[i] = padding;

        var bytes = Encoding.ASCII.GetBytes(text + '\0');
        Array.Copy(bytes, value, Math.Min(size, bytes.Length));
        bw.Write(value);
    }

    #endregion

    #region Reserve
    public void ReserveByte(string name) => Reserve(name, "Byte", 1);
    public void ReserveSByte(string name) => Reserve(name, "SByte", 1);
    public void ReserveBoolean(string name) => Reserve(name, "Boolean", 1);

    public void ReserveInt16(string name) => Reserve(name, "Int16", 2);
    public void ReserveInt32(string name) => Reserve(name, "Int32", 4);
    public void ReserveInt64(string name) => Reserve(name, "Int64", 8);

    public void ReserveUInt16(string name) => Reserve(name, "UInt16", 2);
    public void ReserveUInt32(string name) => Reserve(name, "UInt32", 4);
    public void ReserveUInt64(string name) => Reserve(name, "UInt64", 8);

    public void ReserveHalf(string name) => Reserve(name, "Half", 2);
    public void ReserveSingle(string name) => Reserve(name, "Single", 4);
    public void ReserveDouble(string name) => Reserve(name, "Double", 8);

    #endregion

    #region Fill 

    public void FillByte(string name, byte value) { StepIn(Fill(name, "Byte")); WriteByte(value); StepOut(); }
    public void FillSByte(string name, sbyte value) { StepIn(Fill(name, "SByte")); WriteSByte(value); StepOut(); }
    public void FillBoolean(string name, bool value) { StepIn(Fill(name, "Boolean")); WriteBoolean(value); StepOut(); }

    public void FillInt16(string name, short value) { StepIn(Fill(name, "Int16")); WriteInt16(value); StepOut(); }
    public void FillInt32(string name, int value) { StepIn(Fill(name, "Int32")); WriteInt32(value); StepOut(); }
    public void FillInt64(string name, long value) { StepIn(Fill(name, "Int64")); WriteInt64(value); StepOut(); }

    public void FillUInt16(string name, ushort value) { StepIn(Fill(name, "UInt16")); WriteUInt16(value); StepOut(); }
    public void FillUInt32(string name, uint value) { StepIn(Fill(name, "UInt32")); WriteUInt32(value); StepOut(); }
    public void FillUInt64(string name, ulong value) { StepIn(Fill(name, "UInt64")); WriteUInt64(value); StepOut(); }

    public void FillHalf(string name, Half value) { StepIn(Fill(name, "Half")); WriteHalf(value); StepOut(); }
    public void FillSingle(string name, float value) { StepIn(Fill(name, "Single")); WriteSingle(value); StepOut(); }
    public void FillDouble(string name, double value) { StepIn(Fill(name, "Double")); WriteDouble(value); StepOut(); }

    #endregion
}
