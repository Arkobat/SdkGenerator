using SdkGenerator.Model.Definition;
using SdkGenerator.Shared.Model;

namespace SdkGenerator.Convertor;

public interface ITypeConvertor : IConvertor
{
    public Type TypeToConvert();
    public string ConvertProperty(SchemaProperty context);
}

public interface ITypeConvertor<T> : ITypeConvertor
{
    Type ITypeConvertor.TypeToConvert() => typeof(T);
}