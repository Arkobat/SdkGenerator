using SchemaConsumer.Model.Converter;

namespace SchemaConsumer.Convertor.CSharp;

public class CSharpClassConvertor : IClassConvertor
{
    public string TargetLanguage => Language.CSharp;

    public string GetClassTemplate()
    {
        return
            """
            namespace {{namespace}};
            {% for import in imports %}
            using {{import}};{% endfor %}

            public {% if interface %}interface{% else %}{% if abstract %}abstract {% endif %}class{% endif %} {{class_name}} {
            {% for property in properties %}
                public {{property.type}} {{property.name}} { get; set; }{% endfor %}
                
            }
            """;
    }

    public string FormatProperty(ClassProperty classProperty)
    {
        throw new NotImplementedException();
    }

    public string Constructor(string className, IEnumerable<ClassProperty> properties)
    {
        throw new NotImplementedException();
    }

    public string Property(string type, string name)
    {
        return $$"""public {{type}} {{name}} {get; set;} """;
    }
    
}