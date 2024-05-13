using SdkGenerator.Model.Definition;
using SdkGenerator.Shared.Model;
using YamlDotNet.Serialization;

namespace SdkGenerator.Service;

public class DtoDirectory(IDeserializer deserializer)
{
    private readonly Dictionary<string, Schema> _dictionary = new();
    private readonly Dictionary<string, Type> _builtInTypes = new();

    public DtoDirectory Register<T>(string name)
    {
        _builtInTypes.Add(name.ToLower(), typeof(T));
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

    public Dictionary<string, Schema> DefaultSchemas => deserializer.Deserialize<Dictionary<string, Schema>>(Yaml);

    private const string Yaml =
        """
        Types:
          "SchemaExtractor.Model.Example.Person":
            type: "Object"
            generics:
            - "T"
            properties:
            - type: "guid"
              name: "PersonId"
              nullable: false
            - type: "string"
              name: "FirstName"
              nullable: false
            - type: "string"
              name: "MiddleName"
              nullable: true
            - type: "string"
              name: "LastName"
              nullable: false
            - type: "int32"
              name: "Age"
              nullable: false
            - type: "dateOnly"
              name: "Birthday"
              nullable: false
            - type: "SchemaExtractor.Model.Example.Gender"
              name: "Gender"
              nullable: false
            - type: "List<SchemaExtractor.Model.Example.Person<T>>"
              name: "Parents"
              nullable: false
            - type: "Map<string, SchemaExtractor.Model.Example.Address>"
              name: "Address"
              nullable: false
            - type: "List<string>"
              name: "RandomSet"
              nullable: false
            namespace: "SchemaExtractor.Model.Example"
            name: "Person"
          "SchemaExtractor.Model.Example.Gender":
            type: "Enum"
            values:
            - "Male"
            - "Female"
            namespace: "SchemaExtractor.Model.Example"
            name: "Gender"
          "SchemaExtractor.Model.Example.Address":
            type: "Object"
            properties:
            - type: "string"
              name: "Street"
              nullable: false
            - type: "int32"
              name: "Number"
              nullable: false
            namespace: "SchemaExtractor.Model.Example"
            name: "Address"

        """;

    /*
    public static List<Schema> DefaultSchemas => new()
    {
        new ObjectSchema
        {
            Namespace = "SdkGenerator.PersonExample",
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
                    Type = "SdkGenerator.PersonExample.Address",
                    Name = "Address",
                    Nullable = true
                },
                new SchemaProperty
                {
                    Type = "SdkGenerator.PersonExample.Company",
                    Name = "Company",
                    Nullable = true
                }
            ]
        },
        new ObjectSchema
        {
            Namespace = "SdkGenerator.PersonExample",
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