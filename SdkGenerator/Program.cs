// See https://aka.ms/new-console-template for more information

using Scriban;
using SdkGenerator.Model;
using SdkGenerator.Service;

var model = new
{
    Namespace = "SdkGenerator",
    Abstract = true,
    Interface = false,
    ClassName = "Person",
    Imports = new List<string>
    {
        "SdkGenerator.Models",
        "SdkGenerator.Service",
        "SdkGenerator.Database",
    },
    Properties = new List<Property>()
    {
        new() { Name = "Name", Type = "PropertyType.String" },
        new() { Name = "Age", Type = "PropertyType.Int" }
    }
};


var file = """
           namespace {{namespace}};
           {% for import in imports %}
           using {{import}};{% endfor %}

           public {% if interface %}interface{% else %}{% if abstract %}abstract {% endif %}class{% endif %} {{class_name}} {
           {% for property in properties %}
               public {{property.type}} {{property.name}} { get; set; }{% endfor %}
               
           }
           """;


var template = Template.ParseLiquid(file);
var result = template.Render(new ExtractorService().GetTemplate<ClassTemplate>()); // => "Hello World!" 

Console.WriteLine(result);