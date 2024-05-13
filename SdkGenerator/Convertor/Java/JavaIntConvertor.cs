using SdkGenerator.Model.Definition;
using SdkGenerator.Shared.Model;

namespace SdkGenerator.Convertor.Java;

public class JavaIntConvertor : ITypeConvertor<int>
{
    public Type TypeToConvert() => typeof(int);

    public string ConvertProperty(SchemaProperty context)
    {
        return context.Nullable ? "Integer" : "int";
    }

    public string TargetLanguage => Language.Java;
}

public class JavaStringConvertor : ITypeConvertor<string>
{
    public string ConvertProperty(SchemaProperty context)
    {
        return "String";
    }

    public string TargetLanguage => Language.Java;
}