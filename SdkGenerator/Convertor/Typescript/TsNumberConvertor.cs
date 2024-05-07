using SdkGenerator.Model.Definition;

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

    public Type TypeToConvert() =>throw new NotImplementedException();
    public string ConvertProperty(SchemaProperty context) => throw new NotImplementedException();

    private static string ConvertNumber() => "number";

    string ITypeConvertor<byte>.ConvertProperty(SchemaProperty context) => ConvertNumber();
    string ITypeConvertor<decimal>.ConvertProperty(SchemaProperty context) => ConvertNumber();
    string ITypeConvertor<float>.ConvertProperty(SchemaProperty context) => ConvertNumber();
    string ITypeConvertor<double>.ConvertProperty(SchemaProperty context) => ConvertNumber();
    string ITypeConvertor<sbyte>.ConvertProperty(SchemaProperty context) => ConvertNumber();
    string ITypeConvertor<short>.ConvertProperty(SchemaProperty context) => ConvertNumber();
    string ITypeConvertor<ushort>.ConvertProperty(SchemaProperty context) => ConvertNumber();
    string ITypeConvertor<int>.ConvertProperty(SchemaProperty context) => ConvertNumber();
    string ITypeConvertor<uint>.ConvertProperty(SchemaProperty context) => ConvertNumber();
    string ITypeConvertor<long>.ConvertProperty(SchemaProperty context) => ConvertNumber();
    string ITypeConvertor<ulong>.ConvertProperty(SchemaProperty context) => ConvertNumber();

}