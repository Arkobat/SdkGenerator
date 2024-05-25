using SchemaConsumer.Shared.Model;
using SchemaConsumer.Model.Definition;

namespace SchemaConsumer.Convertor.Typescript;

public class TsNumberConvertor :
    ITypeConvertor<byte>,
    ITypeConvertor<decimal>,
    ITypeConvertor<float>,
    ITypeConvertor<double>,
    ITypeConvertor<sbyte>,
    ITypeConvertor<short>,
    ITypeConvertor<ushort>,
    ITypeConvertor<int>,
    ITypeConvertor<uint>,
    ITypeConvertor<long>,
    ITypeConvertor<ulong>
{
    public string TargetLanguage => Language.TypeScript;

    private static string ConvertNumber() => "number";

    public Type TypeToConvert()
    {
        throw new NotImplementedException();
    }

    public string ConvertProperty(SchemaProperty context) => ConvertNumber();

}