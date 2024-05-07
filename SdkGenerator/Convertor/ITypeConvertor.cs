using SdkGenerator.Model.Definition;

namespace SdkGenerator.Convertor;

public interface ITypeConvertor : IConvertor
{
    public abstract Type TypeToConvert();
    public string ConvertProperty(SchemaProperty context);
}

public interface ITypeConvertor<T> : ITypeConvertor
{
    public new Type TypeToConvert() => typeof(T);
    public new string ConvertProperty(SchemaProperty context);
}