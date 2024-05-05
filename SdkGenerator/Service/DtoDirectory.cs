using SdkGenerator.Model.Definition;

namespace SdkGenerator.Service;

public class DtoDirectory
{
    private readonly Dictionary<string, Schema> _dictionary = new();

    private string TemplateToPath(Schema template) => $"{template.Namespace}.{template.Name}";

    public bool IsRegistered(Schema template) => IsRegistered(TemplateToPath(template));
    public bool IsRegistered(string fullPath) => _dictionary.ContainsKey(fullPath);

    public Schema Get(string fullPath)
    {
        return _dictionary[fullPath];
    }

    public void Register(Schema template)
    {
        _dictionary.Add(TemplateToPath(template), template);
    }

    public List<Schema> GetAll()
    {
        return _dictionary.Values.ToList();
    }
}