using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace HKX2E.SourceGenerators;

[Generator]
public class HavokMemberAccessGenerator : ISourceGenerator
{
	public void Initialize(GeneratorInitializationContext context) { }

	public void Execute(GeneratorExecutionContext context)
	{
		var ihavokObject = context.Compilation.GetTypeByMetadataName("HKX2E.IHavokObject");
		if (ihavokObject == null)
			return;

		var processedClasses = new HashSet<string>();

		foreach (var tree in context.Compilation.SyntaxTrees)
		{
			context.CancellationToken.ThrowIfCancellationRequested();

			var model = context.Compilation.GetSemanticModel(tree);
			var root = tree.GetRoot(context.CancellationToken);

			foreach (var classDecl in root.DescendantNodes().OfType<ClassDeclarationSyntax>())
			{
				context.CancellationToken.ThrowIfCancellationRequested();

				var classSymbol =
					model.GetDeclaredSymbol(classDecl, context.CancellationToken)
					as INamedTypeSymbol;
				if (classSymbol == null)
					continue;

				var fullName = classSymbol.ToDisplayString();
				if (!processedClasses.Add(fullName))
					continue;

				if (
					!classSymbol.AllInterfaces.Contains(
						ihavokObject,
						SymbolEqualityComparer.Default
					)
				)
					continue;

				var members = CollectPublicMembers(classSymbol);
				bool isOverride = BaseImplementsIHavokObject(classSymbol, ihavokObject);
				var source = GenerateSource(classSymbol, members, isOverride);
				context.AddSource(
					classSymbol.Name + ".MemberAccess.g.cs",
					SourceText.From(source, Encoding.UTF8)
				);
			}
		}
	}

	private static bool BaseImplementsIHavokObject(
		INamedTypeSymbol classSymbol,
		INamedTypeSymbol ihavokObject
	)
	{
		var baseType = classSymbol.BaseType;
		while (baseType != null)
		{
			if (baseType.AllInterfaces.Contains(ihavokObject, SymbolEqualityComparer.Default))
				return true;
			baseType = baseType.BaseType;
		}
		return false;
	}

	private static List<MemberEntry> CollectPublicMembers(INamedTypeSymbol classSymbol)
	{
		var seen = new HashSet<string>();
		var result = new List<MemberEntry>();

		var current = classSymbol;
		while (current != null)
		{
			foreach (var member in current.GetMembers())
			{
				if (
					member is IPropertySymbol prop
					&& prop.DeclaredAccessibility == Accessibility.Public
					&& !prop.IsStatic
					&& !prop.IsIndexer
					&& seen.Add(prop.Name)
				)
				{
					bool canSet =
						prop.SetMethod != null
						&& prop.SetMethod.DeclaredAccessibility == Accessibility.Public;
					AddEntry(result, prop.Name, prop.Type, canSet);
				}
				else if (
					member is IFieldSymbol field
					&& field.DeclaredAccessibility == Accessibility.Public
					&& !field.IsStatic
					&& !field.IsConst
					&& !field.IsImplicitlyDeclared
					&& seen.Add(field.Name)
				)
				{
					bool canSet = !field.IsReadOnly;
					AddEntry(result, field.Name, field.Type, canSet);
				}
			}

			current = current.BaseType;
		}

		return result;
	}

	private static void AddEntry(
		List<MemberEntry> result,
		string name,
		ITypeSymbol type,
		bool canSet
	)
	{
		var entry = new MemberEntry();
		entry.Name = name;
		entry.TypeofName = FormatTypeForTypeof(type);
		entry.CanSet = canSet;

		bool isNullableRef =
			!type.IsValueType && type.NullableAnnotation == NullableAnnotation.Annotated;
		if (isNullableRef)
			entry.SetCast = "(" + entry.TypeofName + "?)value";
		else
			entry.SetCast = "(" + entry.TypeofName + ")value!";

		entry.IsList = false;
		entry.ListElementCast = "";
		entry.ListElementTypeName = "";
		if (type is INamedTypeSymbol namedType && namedType.IsGenericType)
		{
			var original = namedType.OriginalDefinition;
			if (
				original.MetadataName == "IList`1"
				&& original.ContainingNamespace != null
				&& original.ContainingNamespace.ToDisplayString() == "System.Collections.Generic"
			)
			{
				entry.IsList = true;
				var elementType = namedType.TypeArguments[0];
				var elementTypeName = FormatTypeForTypeof(elementType);
				entry.ListElementTypeName = elementTypeName;
				bool elementNullableRef =
					!elementType.IsValueType
					&& elementType.NullableAnnotation == NullableAnnotation.Annotated;
				if (elementNullableRef)
					entry.ListElementCast = "(" + elementTypeName + "?)value";
				else
					entry.ListElementCast = "(" + elementTypeName + ")value!";
			}
		}

		result.Add(entry);
	}

	private static string FormatTypeForTypeof(ITypeSymbol type)
	{
		var name = type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

		// Only strip prefixes covered by using directives in generated code.
		// Do NOT strip global::System. broadly — types like Half conflict with the HKX2E.Type enum.
		name = name.Replace("global::System.Collections.Generic.", "");
		name = name.Replace("global::System.Numerics.", "");
		name = name.Replace("global::HKX2E.", "");

		// typeof(T?) is invalid for reference types; nullable value types (Nullable<T>) are fine.
		if (
			type.NullableAnnotation == NullableAnnotation.Annotated
			&& !type.IsValueType
			&& name.EndsWith("?")
		)
		{
			name = name.Substring(0, name.Length - 1);
		}

		return name;
	}

	private static string GenerateSource(
		INamedTypeSymbol classSymbol,
		List<MemberEntry> members,
		bool isOverride
	)
	{
		var mod = isOverride ? "override" : "virtual";
		var sb = new StringBuilder();
		sb.AppendLine("// <auto-generated />");
		sb.AppendLine("#nullable enable");
		sb.AppendLine("using System.Collections.Generic;");
		sb.AppendLine("using System.Numerics;");
		sb.AppendLine();
		sb.AppendLine("namespace HKX2E");
		sb.AppendLine("{");
		sb.Append("    public partial class ").AppendLine(classSymbol.Name);
		sb.AppendLine("    {");

		GenerateLookupMemberType(sb, members, mod);
		sb.AppendLine();
		GenerateGetMember(sb, members, mod);
		sb.AppendLine();
		GenerateGetMemberGeneric(sb, members, mod);
		sb.AppendLine();
		GenerateSetMember(sb, members, mod);
		sb.AppendLine();
		GenerateSetMemberGeneric(sb, members, mod);
		sb.AppendLine();
		GenerateAddToList(sb, members, mod);
		sb.AppendLine();
		GenerateAddToListGeneric(sb, members, mod);

		sb.AppendLine("    }");
		sb.AppendLine("}");
		return sb.ToString();
	}

	private static void GenerateLookupMemberType(
		StringBuilder sb,
		List<MemberEntry> members,
		string mod
	)
	{
		if (members.Count == 0)
		{
			sb.Append("        public ")
				.Append(mod)
				.AppendLine(" global::System.Type? LookupMemberType(string name) => null;");
			return;
		}

		sb.Append("        public ")
			.Append(mod)
			.AppendLine(" global::System.Type? LookupMemberType(string name) => name switch");
		sb.AppendLine("        {");
		foreach (var entry in members)
		{
			sb.Append("            \"")
				.Append(entry.Name)
				.Append("\" => typeof(")
				.Append(entry.TypeofName)
				.AppendLine("),");
		}
		sb.AppendLine("            _ => null,");
		sb.AppendLine("        };");
	}

	private static void GenerateGetMember(StringBuilder sb, List<MemberEntry> members, string mod)
	{
		if (members.Count == 0)
		{
			sb.Append("        public ")
				.Append(mod)
				.AppendLine(" object? GetMember(string name) => null;");
			return;
		}

		sb.Append("        public ")
			.Append(mod)
			.AppendLine(" object? GetMember(string name) => name switch");
		sb.AppendLine("        {");
		foreach (var entry in members)
		{
			sb.Append("            \"")
				.Append(entry.Name)
				.Append("\" => this.")
				.Append(entry.Name)
				.AppendLine(",");
		}
		sb.AppendLine("            _ => null,");
		sb.AppendLine("        };");
	}

	private static void GenerateSetMember(StringBuilder sb, List<MemberEntry> members, string mod)
	{
		var settable = new List<MemberEntry>();
		foreach (var m in members)
		{
			if (m.CanSet)
				settable.Add(m);
		}

		if (settable.Count == 0)
		{
			sb.Append("        public ")
				.Append(mod)
				.AppendLine(" bool SetMember(string name, object? value) => false;");
			return;
		}

		sb.Append("        public ")
			.Append(mod)
			.AppendLine(" bool SetMember(string name, object? value)");
		sb.AppendLine("        {");
		sb.AppendLine("            switch (name)");
		sb.AppendLine("            {");
		foreach (var entry in settable)
		{
			sb.Append("                case \"")
				.Append(entry.Name)
				.Append("\": this.")
				.Append(entry.Name)
				.Append(" = ")
				.Append(entry.SetCast)
				.AppendLine("; return true;");
		}
		sb.AppendLine("                default: return false;");
		sb.AppendLine("            }");
		sb.AppendLine("        }");
	}

	private static void GenerateAddToList(StringBuilder sb, List<MemberEntry> members, string mod)
	{
		var listMembers = new List<MemberEntry>();
		foreach (var m in members)
		{
			if (m.IsList)
				listMembers.Add(m);
		}

		if (listMembers.Count == 0)
		{
			sb.Append("        public ")
				.Append(mod)
				.AppendLine(" bool AddToList(string name, object value) => false;");
			return;
		}

		sb.Append("        public ")
			.Append(mod)
			.AppendLine(" bool AddToList(string name, object value)");
		sb.AppendLine("        {");
		sb.AppendLine("            switch (name)");
		sb.AppendLine("            {");
		foreach (var entry in listMembers)
		{
			sb.Append("                case \"")
				.Append(entry.Name)
				.Append("\": this.")
				.Append(entry.Name)
				.Append(".Add(")
				.Append(entry.ListElementCast)
				.AppendLine("); return true;");
		}
		sb.AppendLine("                default: return false;");
		sb.AppendLine("            }");
		sb.AppendLine("        }");
	}

	// Generic overloads use typeof(T)==typeof(X) guards with (T)(object) casts,
	// which the JIT eliminates for value types, avoiding boxing.

	private static void GenerateGetMemberGeneric(
		StringBuilder sb,
		List<MemberEntry> members,
		string mod
	)
	{
		if (members.Count == 0)
		{
			sb.Append("        public ")
				.Append(mod)
				.AppendLine(" T GetMember<T>(string name) => default!;");
			return;
		}

		sb.Append("        public ").Append(mod).AppendLine(" T GetMember<T>(string name)");
		sb.AppendLine("        {");
		sb.AppendLine("            switch (name)");
		sb.AppendLine("            {");
		foreach (var entry in members)
		{
			sb.Append("                case \"")
				.Append(entry.Name)
				.Append("\" when typeof(T) == typeof(")
				.Append(entry.TypeofName)
				.Append("): return (T)(object)this.")
				.Append(entry.Name)
				.AppendLine("!;");
		}
		sb.AppendLine("                default: return default!;");
		sb.AppendLine("            }");
		sb.AppendLine("        }");
	}

	private static void GenerateSetMemberGeneric(
		StringBuilder sb,
		List<MemberEntry> members,
		string mod
	)
	{
		var settable = new List<MemberEntry>();
		foreach (var m in members)
		{
			if (m.CanSet)
				settable.Add(m);
		}

		if (settable.Count == 0)
		{
			sb.Append("        public ")
				.Append(mod)
				.AppendLine(" bool SetMember<T>(string name, T value) => false;");
			return;
		}

		sb.Append("        public ")
			.Append(mod)
			.AppendLine(" bool SetMember<T>(string name, T value)");
		sb.AppendLine("        {");
		sb.AppendLine("            switch (name)");
		sb.AppendLine("            {");
		foreach (var entry in settable)
		{
			sb.Append("                case \"")
				.Append(entry.Name)
				.Append("\" when typeof(T) == typeof(")
				.Append(entry.TypeofName)
				.Append("): this.")
				.Append(entry.Name)
				.Append(" = (")
				.Append(entry.TypeofName)
				.AppendLine(")(object)value!; return true;");
		}
		sb.AppendLine("                default: return false;");
		sb.AppendLine("            }");
		sb.AppendLine("        }");
	}

	private static void GenerateAddToListGeneric(
		StringBuilder sb,
		List<MemberEntry> members,
		string mod
	)
	{
		var listMembers = new List<MemberEntry>();
		foreach (var m in members)
		{
			if (m.IsList)
				listMembers.Add(m);
		}

		if (listMembers.Count == 0)
		{
			sb.Append("        public ")
				.Append(mod)
				.AppendLine(" bool AddToList<T>(string name, T value) => false;");
			return;
		}

		sb.Append("        public ")
			.Append(mod)
			.AppendLine(" bool AddToList<T>(string name, T value)");
		sb.AppendLine("        {");
		sb.AppendLine("            switch (name)");
		sb.AppendLine("            {");
		foreach (var entry in listMembers)
		{
			sb.Append("                case \"")
				.Append(entry.Name)
				.Append("\" when typeof(T) == typeof(")
				.Append(entry.ListElementTypeName)
				.Append("): this.")
				.Append(entry.Name)
				.Append(".Add((")
				.Append(entry.ListElementTypeName)
				.AppendLine(")(object)value!); return true;");
		}
		sb.AppendLine("                default: return false;");
		sb.AppendLine("            }");
		sb.AppendLine("        }");
	}

	private struct MemberEntry
	{
		public string Name;
		public string TypeofName;
		public string SetCast;
		public bool CanSet;
		public bool IsList;
		public string ListElementCast;
		public string ListElementTypeName;
	}
}
