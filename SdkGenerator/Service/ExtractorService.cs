using Microsoft.Extensions.DependencyInjection;
using SdkGenerator.Convertor;
using SdkGenerator.Model;
using SdkGenerator.Model.Example;

namespace SdkGenerator.Service;

public class ExtractorService(DtoDirectory dtoDirectory, IServiceProvider serviceProvider)
{
    public void AutoRegister()
    {
        var types = new List<Type>()
        {
            typeof(Person)
        };

        foreach (var type in types) Register(type);
    }

    private void Register(Type type)
    {
        var services = serviceProvider.GetServices(typeof(ITypeConvertor<>));
        
        
        var fullPath = $"{type.Namespace}.{type.Name}";
        if (dtoDirectory.IsRegistered(fullPath)) return;

        var template = new ClassTemplate
        {
            Namespace = type.Namespace ?? "",
            Abstract = type.IsAbstract,
            Interface = type.IsInterface,
            ClassName = type.Name,
            Properties = []
            //  Properties = type.GetProperties().Select(p => new Property()
            //  {
            //      Name = p.Name,
            //      Type = ParseGeneric(p.PropertyType)
            //  }).ToList()
        };

        dtoDirectory.Register(template);
        foreach (var t in type.GetProperties().Select(p => p.PropertyType))
        {
            Register(t);
        }
    }


    private string ParseGeneric(Type type)
    {
        if (!type.IsGenericType) return type.Name;
        var generics = string.Join(", ", type.GetGenericArguments().Select(g => g.Name));
        return $"{type.Name}<{generics}>";
    }
}