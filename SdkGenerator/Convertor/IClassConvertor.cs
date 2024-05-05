using SdkGenerator.Model.Converter;

namespace SdkGenerator.Convertor;

public interface IClassConvertor : IConvertor
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public string GetClassTemplate();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="classProperty"></param>
    /// <returns></returns>
    public string FormatProperty(ClassProperty classProperty);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="classTemplate"></param>
    /// <returns></returns>
    public ClassTemplate PostTransform(ClassTemplate classTemplate)
    {
        return classTemplate;
    }
}