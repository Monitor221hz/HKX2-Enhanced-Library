using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2E
{
	public class HavokXmlPartialSerializer : HavokXmlSerializer
	{
        public HavokXmlPartialSerializer()
        {
			nameObjectMap = new(ReferenceEqualityComparer.Instance);
		}
        public HavokXmlPartialSerializer(HavokXmlDeserializerContext sharedContext) : this()
        {
			IEnumerable<string> indexedNames = sharedContext.ElementNameMap.Keys;
			uint num;
			foreach (string name in indexedNames)
			{
				if (uint.TryParse(name.AsSpan(1), out num))
				{
					staticIndexes.Add(num);
				}
			}
		}
		public XElement SerializeDetachedObject<T>(T hkObject) where T : IHavokObject
		{
			XElement element = new XElement("hkobject");
			hkObject.WriteXml(this, element);
			return element;
		}
		public XElement SerializeObject<T>(T hkObject) where T : IHavokObject
		{
			XElement ele = new("hkobject");
			string name;
			lock (nameObjectMap)
			{
				if (!nameObjectMap.TryGetValue(hkObject, out string? existingName))
				{

					name = GetIndexedName();
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
		public XElement SerializeNode<T>(T hkNode) where T : hkbNode
		{
			string name = hkNode.name;
			XElement ele = new("hkobject");	
			lock (nameObjectMap)
			{
				if (!nameObjectMap.TryGetValue(hkNode, out string? existingName))
				{
					nameObjectMap.Add(hkNode, name);
				}
				else
				{
					name = existingName;
				}
			}

			ele.Add(new XAttribute("name", name), new XAttribute("class", hkNode.GetType().Name), new XAttribute("signature", FormatSignature(hkNode.Signature)));
			hkNode.WriteXml(this, ele);
			return ele;
		}
		public XElement SerializeNamedObject<T>(T hkObject, string name, out bool existingReference) where T : IHavokObject
		{
			XElement ele = new("hkobject");
			lock (nameObjectMap)
			{
				if (!nameObjectMap.TryGetValue(hkObject, out string? existingName))
				{
					nameObjectMap.Add(hkObject, name);
					existingReference = false;
				}
				else
				{
					existingReference = true;
					name = existingName;
				}
			}
			ele.Add(new XAttribute("name", name), new XAttribute("class", hkObject.GetType().Name), new XAttribute("signature", FormatSignature(hkObject.Signature)));
			hkObject.WriteXml(this, ele);
			return ele;
		}
		public XElement SerializeNamedObject<T>(T hkObject, string name) where T : IHavokObject
		{
			XElement ele = new("hkobject");
			lock (nameObjectMap)
			{
				if (!nameObjectMap.TryGetValue(hkObject, out string? existingName))
				{
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

	}

}
