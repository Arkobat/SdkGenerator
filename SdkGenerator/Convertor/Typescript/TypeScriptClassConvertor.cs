using System.Text;
using SdkGenerator.Extension;

namespace SdkGenerator.Convertor.Typescript;

public class TypeScriptClassConvertor : IClassConvertor
{
    public string TargetLanguage => Language.TypeScript;

    public string GetClassTemplate()
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
        return new StringBuilder()
            .Append(property.Name)
            .AppendIf(property.Nullable, "?")
            .Append(": ")
            .Append(property.Type)
            .ToString();
    }

    public string Constructor(string className, IEnumerable<Property> properties)
    {
        throw new NotImplementedException();
    }

    public string Property(string type, string name)
    {
        return $"{name}: {type}";
    }
}