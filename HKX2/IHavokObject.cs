using System.Xml.Linq;

namespace HKX2E
{
	public interface IHavokObject
	{
		public uint Signature { set; get; }

		public void Read(PackFileDeserializer des, BinaryReaderEx br);

		public void Write(PackFileSerializer s, BinaryWriterEx bw);
		public void WriteXml(IHavokXmlWriter xs, XElement xe);
		public void ReadXml(IHavokXmlReader xd, XElement xe);
		public void WriteMetaData(PackFileSerializer s, BinaryWriterEx bw, ulong metaData)
		{
			bw.Pad(8);
		}
		public ulong ReadMetaData(PackFileDeserializer s, BinaryReaderEx br)
		{
			br.Pad(8);
			return 0;
		}

		/// <summary>
		/// Returns the declared <see cref="global::System.Type"/> of the member with the given name,
		/// or <c>null</c> if no such public member exists on this object.
		/// </summary>
		public global::System.Type? LookupMemberType(string name) => null;

		/// <summary>
		/// Gets the boxed value of the named member, or <c>null</c> if not found.
		/// </summary>
		public object? GetMember(string name) => null;

		/// <summary>
		/// Sets the named member. Returns <c>true</c> if found and set.
		/// </summary>
		public bool SetMember(string name, object? value) => false;

		/// <summary>
		/// Appends a value to the named <see cref="System.Collections.Generic.IList{T}"/> member.
		/// Returns <c>true</c> if found and is a list.
		/// </summary>
		public bool AddToList(string name, object value) => false;

		/// <summary>
		/// Generic <see cref="GetMember(string)"/>. JIT eliminates boxing when T matches the member type.
		/// </summary>
		public T GetMember<T>(string name) => default!;

		/// <summary>
		/// Generic <see cref="SetMember(string, object?)"/>. JIT eliminates boxing when T matches the member type.
		/// </summary>
		public bool SetMember<T>(string name, T value) => false;

		/// <summary>
		/// Generic <see cref="AddToList(string, object)"/>. JIT eliminates boxing when T matches the element type.
		/// </summary>
		public bool AddToList<T>(string name, T value) => false;
	}
}
