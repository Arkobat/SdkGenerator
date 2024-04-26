using SdkGenerator.Convertor;

namespace SdkGenerator.Service;

public class ConverterService(
    DtoDirectory dtoDirectory,
    IClassConvertor classConvertor
)
{
    public void ConvertType<T>() => ConvertType(typeof(T));

    public void ConvertType(Type type)
    {
        var classTemplate = classConvertor.GetClassTemplate();
    }
}