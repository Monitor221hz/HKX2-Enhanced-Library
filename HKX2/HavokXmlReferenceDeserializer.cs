using HKX2E.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Xml;
using System.Xml.Linq;

namespace HKX2E
{
	public class HavokXmlReferenceDeserializer : HavokXmlDeserializer
	{
		private int nodeCount = 0;
		private Dictionary<string, int> nameOrderLookup;
		// store deserialized
		private Dictionary<IHavokObject, HavokObjectReference> objectReferenceMap;
		private Dictionary<string, List<IHavokReference>> referenceNameMap;

        public HavokXmlReferenceDeserializer() : base()
        {
			nameOrderLookup = new(); 
            objectReferenceMap = new(ReferenceEqualityComparer.Instance);
            referenceNameMap = new();
        }
        public HavokXmlReferenceDeserializer(HavokXmlDeserializerOptions options) : base(options)
        {
            nameOrderLookup = new();
            objectReferenceMap = new(ReferenceEqualityComparer.Instance);
            referenceNameMap = new();
        }
        public HavokXmlReferenceDeserializer(HavokXmlDeserializerContext context) : base(context)
        {
            nameOrderLookup = new();
            objectReferenceMap = new(ReferenceEqualityComparer.Instance);
            referenceNameMap = new();
        }
        protected void AddTraversedNode(string name)
		{
			nameOrderLookup.Add(name, nodeCount++);
		}
        public int GetOrder(string name) => nameOrderLookup.TryGetValue(name, out var index) ? index : 0;
		public virtual void UpdateObjectByName(string name, IHavokObject newObject)
		{
			lock (objectNameMap)
			{
				if (objectNameMap.TryGetValue(name, out var existingObject))
				{
					UpdateDirectReference(existingObject, newObject);
					UpdatePropertyReferences(name, newObject);
					//objectNameMap[name] = newObject;
				}
#if DEBUG_VERBOSE
				else
				{

					Debug.WriteLine($"Could not find object with name {name}");
				}
#endif
			}
		}
		public virtual void UpdateDirectReference(IHavokObject existingObject, IHavokObject newObject)
		{
			if (objectReferenceMap.TryGetValue(existingObject, out var existingReference))
			{
				existingReference.Update(newObject);
			}
#if DEBUG_VERBOSE
						else
						{
							Debug.WriteLine($"Could not update direct reference for object of type {existingObject.GetType()}");
						}
#endif

		}
		public virtual void UpdatePropertyReferences<T>(string name, T newObject) where T : IHavokObject
		{
			if (referenceNameMap.TryGetValue(name, out var havokReferences))
			{
				foreach (IHavokReference reference in havokReferences)
				{
					reference.Update(newObject);
				}
			}
		}
		public virtual void UpdateMapping(string name, IHavokObject newObject)
		{
			if (objectNameMap.ContainsKey(name))
			{
				objectNameMap[name] = newObject;
			}
#if DEBUG_VERBOSE
						else
						{
							Debug.WriteLine($"Could not update mapping for object {name}");
						}
#endif

		}
		public virtual void AddPropertyReference(string name, IHavokObject owner, string propertyName, int listIndex)
		{
			HavokIndexPropertyReference reference = new HavokIndexPropertyReference(GetObjectReference(owner), propertyName, listIndex);
			List<IHavokReference> referenceList;
			lock (referenceNameMap)
			{
				if (referenceNameMap.TryGetValue(name, out referenceList!))
				{
					referenceList.Add(reference);
					return;
				}
			}
			referenceList = new();
			referenceList.Add(reference);
			lock (referenceNameMap)
			{
				referenceNameMap.Add(name, referenceList);
			}
		}
		public void AddPropertyReference(string name, IHavokObject owner, string propertyName)
		{
			HavokPropertyReference reference = new HavokPropertyReference(GetObjectReference(owner), propertyName);
			List<IHavokReference> referenceList;
			lock (referenceNameMap)
			{
				if (referenceNameMap.TryGetValue(name, out referenceList!))
				{
					referenceList.Add(reference);
					return;
				}
			}
			referenceList = new();
			referenceList.Add(reference);
			lock (referenceNameMap)
			{
				referenceNameMap.Add(name, referenceList);
			}
		}
		public HavokObjectReference GetObjectReference(IHavokObject havokObject)
		{
			lock (objectReferenceMap)
			{
				if (objectReferenceMap.TryGetValue(havokObject, out var existingReference))
				{
					return existingReference;
				}
			}
			HavokObjectReference objectReference = new(havokObject);
			lock (objectReferenceMap)
			{
				objectReferenceMap.Add(havokObject, objectReference);
			}
			return objectReference;
		}


		public virtual IHavokObject Deserialize(Stream stream, HavokXmlDeserializerContext context, HavokXmlDeserializerOptions options)
		{
			var document = XDocument.Load(stream, LoadOptions.SetLineInfo);;
			nameOrderLookup = new(StringComparer.OrdinalIgnoreCase);
			objectReferenceMap = new(ReferenceEqualityComparer.Instance);
			referenceNameMap = new();
			objectNameMap = context.ObjectNameMap;
			elementNameMap = context.ElementNameMap;
			this.options = options;

			var hksection = document.Element("hkpackfile")?.Element("hksection");
			if (hksection is null)
				throw new Exception("Xml missing hkpackfile and hksection tag");

			//skip node collection

			var testnode = elementNameMap.First(item => item.Value.Attribute("class")!.Value == "hkRootLevelContainer").Value;
			var rootrefName = testnode.Attribute("name")!.Value;
			var testobj = ConstructVirtualClass<hkRootLevelContainer>(testnode);
			objectNameMap.Add(rootrefName, testobj);
			AddTraversedNode(rootrefName);
			testobj.ReadXml(this, testnode);

			var hkRootLevelContainer = objectNameMap.First(item => item.Value.Signature == 0x2772c11e).Value;

			return hkRootLevelContainer;
		}
		public virtual IHavokObject Deserialize(Stream stream)
		{
			var document = XDocument.Load(stream, LoadOptions.SetLineInfo);
			nameOrderLookup = new(StringComparer.OrdinalIgnoreCase);
			objectReferenceMap = new(ReferenceEqualityComparer.Instance);
			referenceNameMap = new();
			objectNameMap = new();
			elementNameMap = new();
			options = HavokXmlDeserializerOptions.None;

			var hksection = document.Element("hkpackfile")?.Element("hksection");
			if (hksection is null)
				throw new Exception("Xml missing hkpackfile and hksection tag");

			// collect nodes
			foreach (var item in hksection.Elements())
			{
				var name = item.Attribute("name")!.Value;
#if DEBUG
				elementNameMap.Add(name, item);
#else
				elementNameMap.TryAdd(name, item);
#endif
			}

			var testnode = elementNameMap.First(item => item.Value.Attribute("class")!.Value == "hkRootLevelContainer").Value;
			var rootrefName = testnode.Attribute("name")!.Value;
			var testobj = ConstructVirtualClass<hkRootLevelContainer>(testnode);
			objectNameMap.Add(rootrefName, testobj);
			AddTraversedNode(rootrefName);
			testobj.ReadXml(this, testnode);
			var hkRootLevelContainer = objectNameMap.First(item => item.Value.Signature == 0x2772c11e).Value;

			return hkRootLevelContainer;
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

		public override IList<T> ReadClassPointerArray<T>(IHavokObject owner, XElement element, string name) where T : default
		{
			var ele = GetPropertyElement(element, name);
			if (ele is null)
				return new List<T>();

			var result = new List<T>();

			if (!int.TryParse(ele.Attribute("numelements")?.Value, out int count))
				throw new Exception($"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

			if (count == 0)
				return result;

			var refNames = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < refNames.Length; i++)
			{
				string? refName = refNames[i];
				if (objectNameMap.TryGetValue(refName, out IHavokObject? value) && value is T obj)
				{
					AddPropertyReference(refName, owner, name, i);
					result.Add(obj);
					continue;
				}

				if (!elementNameMap.TryGetValue(refName, out XElement? refEle))
					throw new Exception($"Reference symbol '{refName}' not found. Make sure it defined somewhere. at Line {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

				var ret = (T)ConstructVirtualClass<T>(refEle);
				ret.ReadXml(this, refEle);
				objectNameMap.Add(refName, ret);
				AddTraversedNode(refName);
				AddPropertyReference(refName, owner, name, i);
				result.Add(ret);
			}
			return result;
		}

		public override T?[] ReadClassPointerCStyleArray<T>(IHavokObject owner, XElement element, string name, short length) where T :default
		{
			var ele = GetPropertyElement(element, name);
			if (ele is null)
				return Array.Empty<T>();

			var arr = new T?[length];

			var refNames = ele.Value.Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
			if (refNames.Length != length)
				throw new Exception($"Content's elements mismatch property requierd. at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {arr.Length}");
			foreach (var (refName, i) in refNames.Select((v, i) => (v, i)))
			{
				if (refName == "null")
				{
					arr[i] = default;
					continue;
				}

				if (objectNameMap.TryGetValue(refName, out var value) && value is T obj)
				{
					arr[i] = obj;
					AddPropertyReference(refName, owner, name, i);
					continue;
				}

				if (!elementNameMap.TryGetValue(refName, out var refEle))
					throw new Exception($"Reference symbol '{refName}' not found. Make sure it defined somewhere. at Line {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

				var ret = (T)ConstructVirtualClass<T>(refEle);
				ret.ReadXml(this, refEle);
				objectNameMap.Add(refName, ret);
				AddTraversedNode(refName);
				AddPropertyReference(refName, owner, name, i);
				arr[i] = ret;
			}
			return arr;
		}
	}
}
