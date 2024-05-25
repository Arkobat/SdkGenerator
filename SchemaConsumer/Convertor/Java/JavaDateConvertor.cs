using SchemaConsumer.Shared.Model;

namespace SchemaConsumer.Convertor.Java;

public class JavaDateConvertor : ITypeConvertor<DateTime>
{
    public string TargetLanguage => Language.Java;
    public string ConvertProperty(SchemaProperty context)
    {
        return "DateTime";
    }
}