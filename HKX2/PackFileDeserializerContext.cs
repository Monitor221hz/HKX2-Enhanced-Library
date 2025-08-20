using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2E
{
    public class PackFileDeserializerContext
    {
        public PackFileDeserializerContext(Dictionary<uint, IHavokObject> deserializedObjects)
        {
            DeserializedObjects = deserializedObjects;
        }

        public static explicit operator HavokXmlDeserializerContext(PackFileDeserializerContext context)
        {
            Dictionary<string, IHavokObject> objectNameMap = new();

            foreach (var kvp in context.DeserializedObjects)
            {
                objectNameMap.Add($"#{kvp.Key:0000}", kvp.Value);
            }
            Dictionary<string, XElement> elementNameMap = new(); 
            HavokXmlDeserializerOptions options = HavokXmlDeserializerOptions.None;

            return new HavokXmlDeserializerContext(objectNameMap, elementNameMap, options);
        }
        public Dictionary<uint, IHavokObject> DeserializedObjects { get; set; }
    }
}