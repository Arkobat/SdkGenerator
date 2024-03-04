namespace SdkGenerator.Convertor;

public interface ITypeConvertor<T> : IConvertor
{
    public string ConvertProperty();
}