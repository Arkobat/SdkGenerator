using SdkGenerator.Model;

namespace SdkGenerator.Service;

public class DtoDirectory
{
    private readonly Dictionary<string, ClassTemplate> _dictionary = new();

    private string TemplateToPath(ClassTemplate template) => $"{template.Namespace}.{template.ClassName}";

    public bool IsRegistered(ClassTemplate template) => IsRegistered(TemplateToPath(template));
    public bool IsRegistered(string fullPath) => _dictionary.ContainsKey(fullPath);

    public ClassTemplate Get(string fullPath)
    {
        return _dictionary[fullPath];
    }

    public void Register(ClassTemplate template)
    {
        _dictionary.Add(TemplateToPath(template), template);
    }

    public List<ClassTemplate> GetAll()
    {
        return _dictionary.Values.ToList();
    }
}