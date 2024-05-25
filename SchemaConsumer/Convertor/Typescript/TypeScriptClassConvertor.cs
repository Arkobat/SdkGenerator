using System.Text;
using SchemaConsumer.Model.Converter;
using SchemaConsumer.Extension;

namespace SchemaConsumer.Convertor.Typescript;

public class TypeScriptClassConvertor : IClassConvertor
{
    public string TargetLanguage => Language.TypeScript;

    public string GetClassTemplate()
    {
        return
            """
            {% for import in imports %}import {{import}};
            {% endfor %}
            export interface {{class}} {
            {% for property in properties %}
                {{property.name}}: {{property.type}}{% endfor %}
                
            }
            """;
    }

    public string FormatProperty(ClassProperty classProperty)
    {
        return new StringBuilder()
            .Append(classProperty.Name)
            .AppendIf(classProperty.Nullable, "?")
            .Append(": ")
            .Append(classProperty.Type)
            .ToString();
    }
}