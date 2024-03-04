namespace SdkGenerator.Convertor.CSharp;

public class CSharpClassConvertor : IClassConvertor
{
    public string TargetLanguage => Language.CSharp;

    public string ClassTemplate()
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
}