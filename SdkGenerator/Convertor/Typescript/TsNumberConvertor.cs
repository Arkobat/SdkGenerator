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
    public string ConvertProperty()
    {
        throw new NotImplementedException();
    }

    private static string ConvertNumber() => "number";

    string ITypeConvertor<byte>.ConvertProperty() => ConvertNumber();
    string ITypeConvertor<decimal>.ConvertProperty() => ConvertNumber();
    string ITypeConvertor<float>.ConvertProperty() => ConvertNumber();
    string ITypeConvertor<double>.ConvertProperty() => ConvertNumber();
    string ITypeConvertor<sbyte>.ConvertProperty() => ConvertNumber();
    string ITypeConvertor<short>.ConvertProperty() => ConvertNumber();
    string ITypeConvertor<ushort>.ConvertProperty() => ConvertNumber();
    string ITypeConvertor<int>.ConvertProperty() => ConvertNumber();
    string ITypeConvertor<uint>.ConvertProperty() => ConvertNumber();
    string ITypeConvertor<long>.ConvertProperty() => ConvertNumber();
    string ITypeConvertor<ulong>.ConvertProperty() => ConvertNumber();
}