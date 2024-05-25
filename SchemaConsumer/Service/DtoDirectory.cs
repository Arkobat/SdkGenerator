using SchemaConsumer.Shared.Model;
using SchemaConsumer.Model.Definition;
using YamlDotNet.Serialization;

namespace SchemaConsumer.Service;

public class DtoDirectory(IDeserializer deserializer)
{
    private readonly Dictionary<string, Schema> _dictionary = new();
    private readonly Dictionary<string, Type> _builtInTypes = new();

    public DtoDirectory Register<T>(string name) => Register(typeof(T), name);
    
    public DtoDirectory Register(Type t, string name)
    {
        _builtInTypes.Add(name.ToLower(), t);
        return this;
    }

    public bool TryGetBuiltIn(string name, out Type? type)
    {
        return _builtInTypes.TryGetValue(name, out type);
    }


    private string TemplateToPath(Schema template) => $"{template.Namespace}.{template.Name}";

    public bool IsRegistered(Schema template) => IsRegistered(TemplateToPath(template));
    public bool IsRegistered(string fullPath) => _dictionary.ContainsKey(fullPath);

    public Schema Get(string fullPath)
    {
        return _dictionary[fullPath];
    }

    public void Register(Schema template)
    {
        _dictionary.Add(TemplateToPath(template), template);
    }

    public List<Schema> GetAll()
    {
        return _dictionary.Values.ToList();
    }

    public Dictionary<string, ObjectSchema> DefaultSchemas => deserializer.Deserialize<Dictionary<string, ObjectSchema>>(YamlProvider.DefaultYaml);

    /*
    public static List<Schema> DefaultSchemas => new()
    {
        new ObjectSchema
        {
            Namespace = "SchemaConsumer.PersonExample",
            Name = "Person",
            Properties =
            [
                new SchemaProperty
                {
                    Type = "string",
                    Name = "FirstName"
                },
                new SchemaProperty
                {
                    Type = "string",
                    Name = "LastName"
                },
                new SchemaProperty
                {
                    Type = "int32",
                    Name = "Age"
                },
                new SchemaProperty
                {
                    Type = "SchemaConsumer.PersonExample.Address",
                    Name = "Address",
                    Nullable = true
                },
                new SchemaProperty
                {
                    Type = "SchemaConsumer.PersonExample.Company",
                    Name = "Company",
                    Nullable = true
                }
            ]
        },
        new ObjectSchema
        {
            Namespace = "SchemaConsumer.PersonExample",
            Name = "Company",
            Properties =
            [
                new SchemaProperty
                {
                    Type = "string",
                    Name = "StreetName"
                },
                new SchemaProperty
                {
                    Type = "string",
                    Name = "Number"
                }
            ]
        },
    };
    */
}