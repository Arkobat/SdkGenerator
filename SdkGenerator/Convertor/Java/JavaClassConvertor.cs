using System.Text;
using SdkGenerator.Extension;
using SdkGenerator.Model;

namespace SdkGenerator.Convertor.Java;

public class JavaClassConvertor : IClassConvertor
{
    public string TargetLanguage => Language.Java;

    public string GetClassTemplate()
    {
        return
            """
            package {{namespace}};
            
            {% for import in imports %}
            import {{import}};{% endfor %}
            import a.b.c;
            
            {{class}} {
                
                {% for property in properties %}
                {{property}};{% endfor %}
            
                {{constructor}}
                
                {% for method in data.methods %}
                {{method}};{% endfor %}
                
            }
            """;
    }

    public string Property(Property property)
    {
        return new StringBuilder()
            .AppendIf(property.Nullable, "@Nullable")
            .AppendIf(!property.Nullable, "@NotNull")
            .Append('\n').Append('\t')
            .Append("private")
            .Append(' ').Append(property.Type)
            .Append(' ').Append(property.Name)
            .ToString();
    }


    public string GenericProperty(Property property)
    {
        throw new NotImplementedException();
    }

    public string Constructor(string className, IEnumerable<Property> properties)
    {
        var props = properties.Where(p => p.Required);
        var sb = new StringBuilder()
            .Append("public ").Append(className).Append('(')
            .Append(props.Select(p => $"{p.Type} {p.Type}").JoinAsString(", "))
            .Append(") {\n");
        
        foreach (var prop in props)
        {
            sb.Append("\t\t").Append("this.").Append(prop.Name).Append(" = ").Append(prop.Name).Append(";\n");
        }

        return sb.Append('}').ToString();
    }

}
