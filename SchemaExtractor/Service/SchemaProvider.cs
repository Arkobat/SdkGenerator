using System.Reflection;
using SchemaExtractor.Extension;
using SdkGenerator.Shared.Model;

namespace SchemaExtractor.Service;

public class SchemaProvider(TypeMapper typeMapper)
{
    public Schema ConvertToSchema<T>() => ConvertToSchema(typeof(T));

    public Schema ConvertToSchema(Type t)
    {
        if (t.IsEnum) return ConvertEnumSchema(t);
        return ConvertClassSchema(t);
    }

    private ObjectSchema ConvertClassSchema(Type t)
    {
        return new ObjectSchema()
        {
            Namespace = t.Namespace ?? "",
            Name = t.IsGenericType ? t.Name[..t.Name.IndexOf('`')] : t.Name,
            Abstract = t.IsAbstract ? true : null,
            Extends = t.BaseType is null ? null :
                t.BaseType == typeof(object) ? null : typeMapper.BuiltInOrDefault(t.BaseType),
            Generics = t.GetGenericArguments().Select(p => p.Name).ToList().ToNullableList(),
            Properties = t.GetProperties(BindingFlags.Public
                                         | BindingFlags.Instance
                                         | BindingFlags.DeclaredOnly)
                .Select(p => new SchemaProperty
                {
                    Name = p.Name,
                    Type = typeMapper.BuiltInOrDefault(p.PropertyType),
                    Nullable = p.IsNullable()
                }).ToList()
        };
    }

    private EnumSchema ConvertEnumSchema(Type t)
    {
        return new EnumSchema()
        {
            Namespace = t.Namespace ?? "",
            Name = t.IsGenericType ? t.Name[..t.Name.IndexOf('`')] : t.Name,
            Values = GetEnumValues(t).ToList()
        };
    }

    private IEnumerable<string> GetEnumValues(Type t)
    {
        var values = Enum.GetValues(t);
        foreach (var value in values)
        {
            var name = Enum.GetName(t, value)!;
            yield return name;
        }
    }
}