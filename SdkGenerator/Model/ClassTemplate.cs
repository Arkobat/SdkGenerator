namespace SdkGenerator.Model;

public class ClassTemplate
{
    public required string Namespace { get; set; }
    public required bool Abstract { get; set; }
    public required bool Interface { get; set; }

    public required string ClassName { get; set; }
    public List<string>? Generics { get; set; }

    public required List<PropertyTemplate> Properties { get; set; }
}

public class PropertyTemplate
{
    [SdkType<string>] public required string Type { get; set; }
    public required List<PropertyTemplate> Generics { get; set; }
    public required string Name { get; set; }
}