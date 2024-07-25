using FastMember;

namespace HKX2E
{
	struct HavokSingleReference : IHavokReference
	{
		public IHavokObject Object { get; }
		public string PropertyName { get; }

		public HavokSingleReference(IHavokObject @object, string propertyName)
		{
			Object = @object;
			PropertyName = propertyName;
		}

		public void Update<T>(T value) where T : IHavokObject
		{
			TypeAccessor accessor = TypeAccessor.Create(Object.GetType());
			accessor[Object, PropertyName] = value;
		}
	}
}
