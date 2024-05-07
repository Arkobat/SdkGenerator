using SdkGenerator.Model.Definition;

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
    public Type TypeToConvert() => typeof(string);
    

    public string ConvertProperty(SchemaProperty context)
    {
        return "String";
    }

    public string TargetLanguage => Language.Java;
}