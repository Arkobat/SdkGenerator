using SdkGenerator.Model;

namespace SdkGenerator.Service;

public class ExtractorService
{
    public ClassTemplate GetTemplate<T>() => GetTemplate(typeof(T));

    public ClassTemplate GetTemplate(Type type)
    {
        return new ClassTemplate()
        {
            Namespace = type.Namespace ?? "",
            Imports = [],
            Abstract = type.IsAbstract,
            Interface = type.IsInterface,
            ClassName = type.Name,
            Properties = type.GetProperties().Select(p => new Property()
            {
                Name = p.Name,
                Type = ParseGeneric(p.PropertyType)
            }).ToList()
        };
    }

    private string ParseGeneric(Type type)
    {
        if (!type.IsGenericType) return type.Name;
        var generics = string.Join(", ", type.GetGenericArguments().Select(g => g.Name));
        return $"{type.Name}<{generics}>";
    }
}