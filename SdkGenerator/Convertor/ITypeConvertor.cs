namespace SdkGenerator.Convertor;

public interface ITypeConvertor : IConvertor
{
    public Type GetType();
    public string ConvertProperty();
}

public interface ITypeConvertor<T> : ITypeConvertor
{
    public string ConvertProperty();
}