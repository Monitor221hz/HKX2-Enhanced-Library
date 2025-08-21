using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HKX2E
{
    public class HavokXmlMetaDataPartialDeserializer : HavokXmlPartialRefDeserializer
    {
        protected const ulong nodeNameMask = 0xFUL;

        private static string ExtractNodeName(ulong userData)
        {
            return $"#{(userData >> 4):0000}";
        }

        public override T? ReadClassPointer<T>(IHavokObject owner, XElement element, string name) where T : default
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return default;

            var refName = ele.Value;
            if (refName == "null")
                return default;

            if (objectNameMap.TryGetValue(refName, out IHavokObject? value) && value is T obj)
            {
                AddPropertyReference(refName, owner, name);
                return obj;
            }

            if (!elementNameMap.TryGetValue(refName, out XElement? refEle))
                return default;

            T ret = (T)ConstructVirtualClass<T>(refEle);
            ret.ReadXml(this, refEle);
            objectNameMap.Add(refName, ret);
            AddTraversedNode(refName);
            AddPropertyReference(refName, owner, name);
            return ret;
        }
        public override bool TryGetObject(string name, [NotNullWhen(true)] out IHavokObject? obj)
        {
            lock (objectNameMap)
            {
                return objectNameMap.TryGetValue(name, out obj);
            }
        }
    }

    public class HavokXmlMetaDataSerializer : HavokXmlSerializer
    {
        protected const ulong nodeNameMask = 0xFUL; 
        private static ulong EmbedNodeName(ulong userData, uint name)
        {
            return (userData & nodeNameMask) | (ulong)name << 4; 
        }
        public override void WriteClassPointer<T>(XElement xe, string paramName, T? value) where T : default
        {
            if (value is null)
            {
                WriteString(xe, paramName, "null");
                return;
            }
            if (nameObjectMap.ContainsKey(value))
            {
                var index = nameObjectMap[value];
                var hkparam = WriteString(xe, paramName, index);
            }
            else
            {
                var index = GetIndex(); 
                var indexedName = FormatIndexName(index);
                nameObjectMap.Add(value, indexedName);
                WriteString(xe, paramName, indexedName);
                if (value is hkbNode namedNode)
                {
                    namedNode.userData = EmbedNodeName(namedNode.userData, index);
                }
                var node = WriteNode(value, indexedName);
                value.WriteXml(this, node);
            }
        }
        public override void WriteClassPointerArray<T>(XElement xe, string paramName, IList<T?> values) where T : default
        {
            var indexs = new List<string>();
            var hkparam = WriteParam(xe, paramName);
            hkparam.Add(new XAttribute("numelements", values.Count));
            foreach (var item in values)
            {
                if (item is null)
                {
                    indexs.Add("null");
                    continue;
                }
                if (nameObjectMap.ContainsKey(item))
                {
                    indexs.Add(nameObjectMap[item]);
                    continue;
                }
                var index = GetIndex();
                var indexedName = FormatIndexName(index);
                nameObjectMap.Add(item, indexedName);
                indexs.Add(indexedName);
                if (item is hkbNode namedNode)
                {
                    namedNode.userData = EmbedNodeName(namedNode.userData, index);
                }
                var node = WriteNode(item, indexedName);
                item.WriteXml(this, node);
            }
            hkparam.Add(new XText(string.Join(" ", indexs)));
        }
    }
}
