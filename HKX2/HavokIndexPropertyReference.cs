using System;
using System.Collections.Generic;

namespace HKX2E
{
	struct HavokIndexPropertyReference : IHavokReference
	{
		public HavokIndexPropertyReference(
			HavokObjectReference owner,
			string propertyName,
			int index
		)
		{
			Owner = owner;
			PropertyName = propertyName;
			Index = index;
		}

		public HavokObjectReference Owner { get; }
		public string PropertyName { get; }
		public int Index { get; }

		public void Update<T>(T value)
			where T : IHavokObject
		{
			IHavokObject target = Owner.Object;
			var member = target.GetMember(PropertyName);
#if DEBUG_VERBOSE
			System.Diagnostics.Debug.WriteLine(
				$"{target.GetType()} -> {PropertyName} : {member?.GetType()}"
			);
#endif
			if (member is IList<T> typedList)
			{
				typedList[Index] = value;
				return;
			}

			if (member != null)
			{
				dynamic dynamicList = member;
				dynamicList[Index] = (dynamic)value;
				return;
			}

			throw new InvalidCastException(
				$"Could not cast {PropertyName} to IList<{typeof(T)}> or to IList<dynamic>. Is property invalid?"
			);
		}
	}
}
