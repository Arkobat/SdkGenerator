namespace SchemaConsumer.Model.Converter;

public class ClassTemplate
{
    public required string Namespace { get; set; }
    public required string Class { get; set; }
    public required List<string> Imports { get; set; }
    public required List<string> Properties { get; set; }
}

public class ClassProperty
{
    public required string Type { get; set; }
    public required string Name { get; set; }
    public required bool Nullable { get; set; }
}