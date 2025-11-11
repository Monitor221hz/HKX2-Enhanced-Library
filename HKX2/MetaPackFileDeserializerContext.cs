using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2E
{
    public class MetaPackFileDeserializerContext
    {
        public MetaPackFileDeserializerContext(Dictionary<ulong, IHavokObject> refIDMap)
        {
            ReferenceIDMap = refIDMap;
        }

        public static explicit operator HavokXmlDeserializerContext(
            MetaPackFileDeserializerContext context
        )
        {
            Dictionary<string, IHavokObject> objectNameMap = new();

            foreach (var kvp in context.ReferenceIDMap)
            {
                objectNameMap.Add($"#{kvp.Key:0000}", kvp.Value);
            }
            Dictionary<string, XElement> elementNameMap = new();
            HavokXmlDeserializerOptions options = HavokXmlDeserializerOptions.None;

            return new HavokXmlDeserializerContext(objectNameMap, elementNameMap, options);
        }

        public Dictionary<ulong, IHavokObject> ReferenceIDMap { get; set; }
    }
}
