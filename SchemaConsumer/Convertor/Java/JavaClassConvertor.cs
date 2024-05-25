using System.Text;
using SchemaConsumer.Model.Converter;
using SchemaConsumer.Extension;

namespace SchemaConsumer.Convertor.Java;

public class JavaClassConvertor : IClassConvertor
{
    public string TargetLanguage => Language.Java;

    public string GetClassTemplate()
    {
        return
            """
            package {{namespace}};
            {% for import in imports %}import {{import}};
            {% endfor %}
            public class {{class}} {
                {% for property in properties %}
                {{property}}{% endfor %}
                
                {% for method in data.methods %}
                {{method}};{% endfor %}
                
            }
            """;
    }

    public string FormatProperty(ClassProperty classProperty)
    {
        return $"{(classProperty.Nullable ? "@Nullable" : "@NotNull")}\n\t" +
               $"private {classProperty.Type} {classProperty.Name};";
    }

    public ClassTemplate PostTransform(ClassTemplate classTemplate)
    {
        classTemplate.Imports.Add("import org.jetbrains.annotations.NotNull");
        classTemplate.Imports.Add("import org.jetbrains.annotations.Nullable");
        return classTemplate;
    }
}