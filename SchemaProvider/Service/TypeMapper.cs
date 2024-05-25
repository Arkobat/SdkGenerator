using System.Text;
using SchemaExtractor.Extension;
using SchemaExtractor.Model;

namespace SchemaExtractor.Service;

public class TypeMapper
{
    private readonly Dictionary<TypeWrapper, string> _builtInTypes = new();

    public TypeMapper AddMapping<T>(string name) => AddMapping(typeof(T), name);
    public TypeMapper AddMapping(Type type, string name)
    {
        _builtInTypes.Add(new TypeWrapper(type), name);
        return this;
    }

    //public bool IsBuiltIn(Type type) => _builtInTypes.ContainsKey(new TypeWrapper(type));
    public bool IsBuiltIn(Type type) => _builtInTypes.Keys.Any(k => k.Equals(type));

    public string BuiltInOrDefault(Type type)
    {
        // Check if property is a generic from the class
        if (type.DeclaringType is {IsGenericType: true} && type.DeclaringType.GetGenericArguments().Any(t => t == type))
        {
            return type.Name;
        }

        // Get the name of the property time, either built in or full namespace and name
        var typeName = _builtInTypes.FirstOrDefault(k => k.Key.Equals(type)).Value
            ?? $"{type.Namespace}.{type.Name}";

        // Check if the property is generic, if not, return the name
        if (!type.IsGenericType)
        {
            return typeName;
        }

        // Check if the generic is Nullable<T>, return the typeof(T) instead, as nullability is handled otherwise.
        if (type.IsNullable())
        {
            return BuiltInOrDefault(type.GetGenericArguments()[0]);
        }
        
        // Build the generic generic property
        var sb = new StringBuilder();
        var indexOfGeneric = typeName.IndexOf('`');
        sb.Append(indexOfGeneric == -1 ? typeName : typeName[..indexOfGeneric]);
        sb.Append('<');
        sb.Append(string.Join(", ", type.GetGenericArguments().Select(BuiltInOrDefault)));
        sb.Append('>');

        return sb.ToString();
    }
}