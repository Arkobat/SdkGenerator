namespace SdkGenerator.Convertor.Typescript;

public class TypeScriptClassConvertor : IClassConvertor
{
    public string TargetLanguage => Language.TypeScript;

    public string ClassTemplate()
    {
        return
            """
            {% for import in imports %}
            import {{import}};{% endfor %}

            export interface {{class_name}} {
            {% for property in properties %}
                {{property.name}}: {{property.type}}{% endfor %}
                
            }
            """;
    }

    public string Property(Property property)
    {
        throw new NotImplementedException();
    }

    public string Constructor(string className, List<Property> properties)
    {
        throw new NotImplementedException();
    }

    public string Property(string type, string name)
    {
        return $"{name}: {type}";
    }
}