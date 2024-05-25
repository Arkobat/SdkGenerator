using SchemaConsumer.Shared.Model;
using SchemaConsumer.Model.Definition;

namespace SchemaConsumer.Convertor;

public interface ITypeConvertor : IConvertor
{
    public Type TypeToConvert();
    public string ConvertProperty(SchemaProperty context);
}

public interface ITypeConvertor<T> : ITypeConvertor
{
    Type ITypeConvertor.TypeToConvert() => typeof(T);
}