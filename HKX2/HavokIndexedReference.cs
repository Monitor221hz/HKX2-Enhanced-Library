using FastMember;
using System;
using System.Collections.Generic;

namespace HKX2E
{
	struct HavokIndexedReference : IHavokReference
	{
		public HavokIndexedReference(IHavokObject @object, string propertyName, int index)
		{
			Object = @object;
			PropertyName = propertyName;
			Index = index;
		}

		public IHavokObject Object { get; }
		public string PropertyName { get; }
		public int Index { get; }
		public void Update<T>(T value) where T : IHavokObject
		{
			TypeAccessor accessor = TypeAccessor.Create(Object.GetType());
			var objects = (accessor[Object, PropertyName] as IList<T>);
			if (objects == null)
			{
				throw new InvalidCastException($"Could not cast {PropertyName} to IList<{typeof(T)}. Is property invalid?");
			}
			objects[Index] = value;
		}
	}
}
