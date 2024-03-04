namespace SdkGenerator.Convertor.Java;

public class JavaIntConvertor : ITypeConvertor<int>
{
    public string ConvertProperty()
    {
        throw new NotImplementedException();
    }

    public string TargetLanguage => Language.Java;
}