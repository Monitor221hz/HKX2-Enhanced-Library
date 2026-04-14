namespace HKX2E
{
	struct HavokPropertyReference : IHavokReference
	{
		public HavokPropertyReference(HavokObjectReference owner, string propertyName)
		{
			PropertyName = propertyName;
			Owner = owner;
		}

		public string PropertyName { get; }
		public HavokObjectReference Owner { get; }

		public void Retarget(
			IHavokObjectNameMap objectNameMap,
			INameHavokObjectMap nameObjectMap
		) { }

		public void Update<T>(T value)
			where T : IHavokObject
		{
			Owner.Object.SetMember(PropertyName, value);
		}
	}
}
