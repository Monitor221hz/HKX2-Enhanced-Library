using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HKX2E
{
    public class HavokXmlMetaDataSerializer : HavokXmlSerializer
    {
        protected Dictionary<IHavokObject, ulong> idNodeMap = new(ReferenceEqualityComparer.Instance);

        protected ulong GetIndex(IHavokObject obj)
        {
            lock (idNodeMap)
            {
                if (idNodeMap.TryGetValue(obj, out ulong index))
                {
                    return index; 
                }
            }
            return GetIndex(); 
        }
        protected string GetIndexedName(IHavokObject obj) => FormatIndexName(GetIndex(obj));

        public void ShareContext(MetaPackFileDeserializerContext context)
        {
            foreach (var kvp in context.ReferenceIDMap)
            {
                idNodeMap.TryAdd(kvp.Value, kvp.Key);
            }
        }
        public override void Serialize(IHavokObject rootObject, HKXHeader header, Stream stream)
        {
            nameObjectMap.Clear();

            var index = GetIndexedName(rootObject);

            document = new XDocument(
                new XDeclaration("1.0", "ascii", null),
                new XElement("hkpackfile",
                    new XAttribute("classversion", header.FileVersion),
                    new XAttribute("contentsversion", header.ContentsVersionString),
                    new XAttribute("toplevelobject", index),
                    new XElement("hksection",
                        new XAttribute("name", "__data__"))));

            dataSection = document.Element("hkpackfile").Element("hksection");

            var hkrootcontainer = WriteNode(rootObject, index);
            rootObject.WriteXml(this, hkrootcontainer);

            document.Save(stream);
        }
        public override XElement SerializeObject<T>(T hkObject) where T : default
        {
            XElement ele = new("hkobject");
            string name;
            lock (nameObjectMap)
            {
                if (!nameObjectMap.TryGetValue(hkObject, out string? existingName))
                {

                    name = GetIndexedName(hkObject);
                    nameObjectMap.Add(hkObject, name);
                }
                else
                {
                    name = existingName;
                }
            }
            ele.Add(new XAttribute("name", name), new XAttribute("class", hkObject.GetType().Name), new XAttribute("signature", FormatSignature(hkObject.Signature)));
            hkObject.WriteXml(this, ele);
            return ele;
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
                var index = GetIndexedName(value);
                nameObjectMap.Add(value, index);
                WriteString(xe, paramName, index);
                var node = WriteNode(value, index);
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
                var index = GetIndexedName(item);
                nameObjectMap.Add(item, index);
                indexs.Add(index);
                var node = WriteNode(item, index);
                item.WriteXml(this, node);
            }
            hkparam.Add(new XText(string.Join(" ", indexs)));
        }
    }
}
