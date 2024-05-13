using SdkGenerator.Shared.Model;

namespace SchemaExtractor.Service;

public class ClassProvider(
    SchemaProvider schemaProvider,
    TypeMapper typeMapper
)
{
    private readonly Dictionary<Type, Schema> _schemata = new();

    public void AddClass<T>() => AddClass(typeof(T));

    public void AddClass(Type type)
    {
        if (_schemata.ContainsKey(type)) return;
        if (typeMapper.IsBuiltIn(type)) return;
        var schema = schemaProvider.ConvertToSchema(type);
        _schemata.Add(type, schema);

        if (type.BaseType is not null && !new List<Type> {typeof(object), typeof(Enum)}.Contains(type.BaseType))
        {
            AddClass(type.BaseType);
        }
        

        foreach (var property in type.GetProperties())
        {
            AddClass(property.PropertyType);
            foreach (var generic in property.PropertyType.GetGenericArguments())
            {
                AddClass(generic);
            }
        }
    }

    public Dictionary<string, Schema> GetSchemes()
    {
        return _schemata.Values.ToDictionary(k => $"{k.Namespace}.{k.Name}");
    }
}