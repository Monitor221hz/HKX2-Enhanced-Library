using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace HKX2E.Extensions;

public static class HavokXmlDeserializerExtensions
{
    public static readonly char[] SplitCharList = ['(', ')', ',', ' ', '\n', '\r', '\t'];
    public static readonly char[] SplitSpaceList = { ' ', '\n', '\r', '\t' };

    public static IEnumerable<string> Normalize(string str) =>
        str.Split(
                SplitCharList,
                StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries
            )
            .Select(x => x == "-1.#IND00" ? "0.0" : x)
            .ToArray();

    public static XElement? GetPropertyElement(XContainer element, string name)
    {
        if (name.StartsWith("m_"))
        {
            name = name[2..];
        }
        var eles = element.Elements("hkparam").Where(e => e.Attribute("name")!.Value == name);
        if (!eles.Any())
        {
            return null;
        }
        return eles.First();
    }

    public static XElement? ReadBaseArray(XElement element, string name)
    {
        var ele = GetPropertyElement(element, name);
        if (ele is null)
            return null;

        if (!int.TryParse(ele.Attribute("numelements")?.Value, out var count))
            throw new Exception(
                $"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}"
            );

        if (count == 0)
            return null;

        return ele;
    }

    public static XElement? ReadBaseCStyleArray(XElement element, string name, short length) =>
        GetPropertyElement(element, name);

    public static T ReadValueSpan<T>(XElement element, string name)
        where T : struct, ISpanParsable<T>
    {
        var ele = GetPropertyElement(element, name);
        if (ele is null)
            return default;

        ReadOnlySpan<char> span = ele.Value.AsSpan();
        if (T.TryParse(span, CultureInfo.InvariantCulture, out T value))
            return value;

        throw new FormatException(
            $"Invalid {typeof(T).Name} value '{ele.Value}' at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}"
        );
    }

    public static IList<T> ReadPrimitiveArray<T>(
        XElement element,
        string name,
        Func<string, T> parser
    )
    {
        var ele = ReadBaseArray(element, name);
        if (ele is null)
            return new List<T>();

        return ele
            .Value.Split(
                SplitSpaceList,
                StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries
            )
            .Select(parser)
            .ToList();
    }

    public static T[] ReadPrimitiveCStyleArray<T>(
        XElement element,
        string name,
        short length,
        Func<string, T> parser
    )
    {
        var ele = ReadBaseCStyleArray(element, name, length);

        if (ele is null)
            return new T[length];

        var eles = ele.Value.Split(
            SplitSpaceList,
            StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
        );

        if (eles.Length != length)
            throw new Exception(
                $"Content's elements mismatch for property '{name}'. Expected {length}, but found {eles.Length}. Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}"
            );

        return eles.Select(s => parser(s)).ToArray();
    }

    public static TResult ReadComplexType<TResult>(
        XElement element,
        string name,
        Func<IReadOnlyList<float>, TResult> creator
    )
        where TResult : new()
    {
        var ele = GetPropertyElement(element, name);
        if (ele is null)
            return new TResult();

        var floats = Normalize(ele.Value).Select(float.Parse).ToArray();

        return creator(floats);
    }

    public static IList<TResult> ReadComplexTypeArray<TResult>(
        XElement element,
        string name,
        int chunkSize,
        Func<IReadOnlyList<float>, TResult> creator
    )
    {
        var ele = GetPropertyElement(element, name);

        if (ele is null)
            return new List<TResult>();

        if (!int.TryParse(ele.Attribute("numelements")?.Value, out var count))
            throw new Exception(
                $"'numelements' is not a valid number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}"
            );

        if (count == 0)
            return new List<TResult>();

        var chunks = Normalize(ele.Value).Select(float.Parse).Chunk(chunkSize).ToList();

        if (chunks.Count != count)
            throw new Exception(
                $"Element count mismatch for property '{name}'. Expected {count}, but found {chunks.Count}. Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}"
            );

        return chunks.Select(creator).ToList();
    }

    public static TResult[] ReadComplexCStyleArray<TResult>(
        XElement element,
        string name,
        short length,
        int chunkSize,
        Func<IReadOnlyList<float>, TResult> creator
    )
    {
        var ele = ReadBaseCStyleArray(element, name, length);
        if (ele is null)
            return new TResult[length];

        var chunks = Normalize(ele.Value).Select(s => float.Parse(s)).Chunk(chunkSize).ToList();

        if (chunks.Count != length)
            throw new Exception(
                $"Content's elements mismatch for property '{name}'. Expected {length}, but found {chunks.Count}. Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}"
            );

        return chunks.Select(chunk => creator(chunk)).ToArray();
    }
}
