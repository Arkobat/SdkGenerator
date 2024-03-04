namespace SdkGenerator.Convertor.Java;

public class JavaClassConvertor : IClassConvertor
{
    public string TargetLanguage => Language.Java;

    public string ClassTemplate()
    {
        return
            """
            package {{namespace}};
            {% for import in imports %}
            import {{import}};{% endfor %}

            public {% if interface %}interface{% else %}{% if abstract %}abstract {% endif %}class{% endif %} {{class_name}} {
            {% for property in properties %}
                public {{property.type}} {{property.name}} { get; set; }{% endfor %}
                
            }
            """;
    }
}