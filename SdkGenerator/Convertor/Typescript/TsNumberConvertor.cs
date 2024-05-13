using SdkGenerator.Model.Definition;
using SdkGenerator.Shared.Model;

namespace SdkGenerator.Convertor.Typescript;

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