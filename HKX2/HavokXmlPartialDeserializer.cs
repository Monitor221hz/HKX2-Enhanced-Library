using HKX2E.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Xml;
using System.Xml.Linq;

namespace HKX2E
{

	public class HavokXmlPartialDeserializer : HavokXmlDeserializer
	{
		public HavokXmlPartialDeserializer()
		{
			objectNameMap = new();
			elementNameMap = new();
			options = HavokXmlDeserializerOptions.None;
		}
		public HavokXmlPartialDeserializer(HavokXmlDeserializerOptions options)
		{
			objectNameMap = new();
			elementNameMap = new();
			this.options = options;
		}
		public HavokXmlPartialDeserializer(HavokXmlDeserializerContext context)
		{
			objectNameMap = context.ObjectNameMap;
			elementNameMap = context.ElementNameMap;
			options = context.Options;
		}
		public virtual T DeserializeDetachedObject<T>(XElement element) where T : IHavokObject, new()
		{
			T ret = new T();
			ret.ReadXml(this, element);
			return ret;
		}

		public virtual T DeserializeObjectOverwrite<T>(XElement element) where T : IHavokObject, new()
		{
			string name = element.Attribute("name")!.Value;
			IHavokObject obj = new T();
			obj.ReadXml(this, element);
			lock (objectNameMap)
			{
				if (objectNameMap.ContainsKey(name))
				{
					objectNameMap[name] = obj;
				}
				else
				{
					objectNameMap.Add(name, obj);
				}
			}
			return (T)obj;
		}
		public virtual T DeserializeObject<T>(XElement element) where T : IHavokObject, new()
		{
			string name = element.Attribute("name")!.Value;
			IHavokObject? obj;
			lock (objectNameMap)
			{
				if (objectNameMap.TryGetValue(name, out obj))
				{
					return (T)obj;
				}
			}
			obj = new T();
			obj.ReadXml(this, element);
			lock (objectNameMap)
			{
				objectNameMap.Add(name, obj);
			}
			return (T)obj;
		}
		public virtual T DeserializeNamedObject<T>(XElement element, string name) where T : IHavokObject, new()
		{
			IHavokObject? obj;
			lock (objectNameMap)
			{
				if (objectNameMap.TryGetValue(name, out obj))
				{
					return (T)obj;
				}
			}
			obj = new T();
			obj.ReadXml(this, element);
			lock (objectNameMap)
			{
				objectNameMap.Add(name, obj);
			}
			return (T)obj;
		}
		/// <summary>
		/// Only use this for havok compliant xml, and when the type is unknown.
		/// </summary>
		/// <param name="element"></param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		public virtual IHavokObject DeserializeRuntimeObjectOverwrite(XElement element)
		{
			var name = element.Attribute("name")!.Value;

			var hkClassName = element.Attribute("class")!.Value;
			var hkClass = System.Type.GetType($@"HKX2E.{hkClassName}");
			if (hkClass is null) throw new Exception($@"Havok class type '{hkClassName}' not found!");

			var obj = (IHavokObject)Activator.CreateInstance(hkClass)!;
			if (obj is null) throw new Exception($@"Failed to Activator.CreateInstance({hkClass})");

			if (obj.GetType().IsAssignableTo(hkClass))
			{
				obj.ReadXml(this, element);
				lock (objectNameMap)
				{
					if (objectNameMap.ContainsKey(name))
					{
						objectNameMap[name] = obj;
					}
					else
					{
						objectNameMap.Add(name, obj);
					}
				}
				return obj;
			}
			if (!options.HasFlag(HavokXmlDeserializerOptions.IgnoreNonFatalErrors))
				throw new Exception($@"Could not convert '{hkClass}' to '{obj.GetType()}'. Is source malformed?");

			return hkDummyBuilder.CreateDummy(obj, hkClass);
		}
		/// <summary>
		/// Only use this for havok compliant xml, and when the type is unknown.
		/// </summary>
		/// <param name="element"></param>
		/// <returns></returns>
		/// <exception cref="Exception"></exception>
		public virtual IHavokObject DeserializeRuntimeObject(XElement element)
		{
			var name = element.Attribute("name")!.Value;
			lock (objectNameMap)
			{
				if (objectNameMap.TryGetValue(name, out IHavokObject? value))
				{
					return value!;
				}
			}


			var hkClassName = element.Attribute("class")!.Value;
			var hkClass = System.Type.GetType($@"HKX2E.{hkClassName}");
			if (hkClass is null) throw new Exception($@"Havok class type '{hkClassName}' not found!");

			var obj = (IHavokObject)Activator.CreateInstance(hkClass)!;
			if (obj is null) throw new Exception($@"Failed to Activator.CreateInstance({hkClass})");

			if (obj.GetType().IsAssignableTo(hkClass))
			{
				obj.ReadXml(this, element);
				lock (objectNameMap)
				{
					objectNameMap.Add(name, obj);
				}
				return obj;
			}
			if (!options.HasFlag(HavokXmlDeserializerOptions.IgnoreNonFatalErrors))
				throw new Exception($@"Could not convert '{hkClass}' to '{obj.GetType()}'. Is source malformed?");

			return hkDummyBuilder.CreateDummy(obj, hkClass);
		}
	}
}
