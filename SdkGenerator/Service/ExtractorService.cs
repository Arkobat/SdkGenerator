using SdkGenerator.Convertor;
using SdkGenerator.Model.Converter;
using SdkGenerator.Model.Definition;
using SdkGenerator.Model.Example.PersonExample;

namespace SdkGenerator.Service;

public class ExtractorService(
    DtoDirectory dtoDirectory)
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
        if (DefaultTypeConverter.IsNative(type, out _)) return;
        var fullPath = $"{type.Namespace}.{type.Name}";
        if (dtoDirectory.IsRegistered(fullPath)) return;

        var template = new ObjectSchema()
        {
            Namespace = type.Namespace ?? "",
            Name = type.Name,
            //Properties= type.GetProperties().Select(p => p.PropertyType.Name).ToList()
            Properties = type.GetProperties().Select(p =>
            {
                
                var isNative = DefaultTypeConverter.IsNative(p.PropertyType, out var nativeType);
                return new Property()
                {
                    Name = p.Name,
                    Type = isNative ? nativeType! : p.PropertyType.FullName!,
                    Nullable = false
                };
            }).ToList()
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