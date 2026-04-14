using System;
using System.Linq;

namespace HKX2E;

public class RuntimePatcher
{
	private static IHavokObject ResolvePath(IHavokObject node, string path, out string lastName)
	{
		string[] names = path.Split(
			'/',
			StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries
		);
		int limit = names.Length - 1;
		for (int i = 0; i < limit; i++)
		{
			var member = node.GetMember(names[i]);
			if (member is IHavokObject next)
			{
				node = next;
			}
			else
			{
				throw new InvalidOperationException(
					$"Cannot navigate through member '{names[i]}' on {node.GetType().Name}: "
						+ (
							member == null
								? "member is null"
								: $"member is {member.GetType().Name}, not IHavokObject"
						)
				);
			}
		}
		lastName = names.Last();
		return node;
	}

	public static object? GetProperty(IHavokObject node, string path)
	{
		node = ResolvePath(node, path, out string name);
		return node.GetMember(name);
	}

	public static void SetProperty(IHavokObject node, string path, object? value)
	{
		node = ResolvePath(node, path, out string name);
		node.SetMember(name, value);
	}

	public static void AddPropertyList(IHavokObject node, string path, object value)
	{
		node = ResolvePath(node, path, out string name);
		node.AddToList(name, value);
	}
}
