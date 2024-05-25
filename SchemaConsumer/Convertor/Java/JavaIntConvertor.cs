using SchemaConsumer.Shared.Model;
using SchemaConsumer.Model.Definition;

namespace SchemaConsumer.Convertor.Java;

public class JavaIntConvertor : ITypeConvertor<int>
{
    public string ConvertProperty(SchemaProperty context)
    {
        return context.Nullable ? "Integer" : "int";
    }

    public string TargetLanguage => Language.Java;
}

public class JavaDoubleConvertor : ITypeConvertor<double>
{
    public string ConvertProperty(SchemaProperty context)
    {
        return context.Nullable ? "Double" : "double";
    }

    public string TargetLanguage => Language.Java;
}

public class JavaBoolConvertor : ITypeConvertor<bool>
{
    public string ConvertProperty(SchemaProperty context)
    {
        return context.Nullable ? "Boolean" : "boolean";
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