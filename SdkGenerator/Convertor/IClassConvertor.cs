using SdkGenerator.Model.Converter;

namespace SdkGenerator.Convertor;

public interface IClassConvertor : IConvertor
{
    /// <summary>
    /// Defines the template from which a class template is created from.
    /// Placeholders, conditions and more are supported via <see href="https://github.com/scriban/scriban">Scriban</see>.
    /// </summary>
    /// <returns>A complete class template.</returns>
    public string GetClassTemplate();

    /// <summary>
    /// Formats a class property, to be ready to add into the class.
    /// The output will be available when parsing the class template.
    /// </summary>
    /// <param name="classProperty">The details for the property.</param>
    /// <returns>A formatted property.</returns>
    public string FormatProperty(ClassProperty classProperty);

    /// <summary>
    /// An optional way to further transform a class template, after the system has performed the initial transformation.
    /// </summary>
    /// <param name="classTemplate">The pre parsed template</param>
    /// <returns>An updated template</returns>
    public ClassTemplate PostTransform(ClassTemplate classTemplate)
    {
        return classTemplate;
    }
}