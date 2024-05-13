namespace SdkGenerator.Shared.Model;

public abstract class Schema
{
    public abstract SchemaType Type { get; }
    public required string Namespace { get; set; }
    public required string Name { get; set; }
}

public class ObjectSchema : Schema
{
    public override SchemaType Type => SchemaType.Object;
    public bool? Abstract { get; set; } = false;
    public string? Extends { get; set; } 
    public required List<string>? Generics { get; set; }
    public required List<SchemaProperty> Properties { get; set; }
}

public class EnumSchema : Schema
{
    public override SchemaType Type => SchemaType.Enum;
    public required List<string> Values { get; set; }
}

public class SchemaProperty
{
    public required string Type { get; set; }
    public required string Name { get; set; }
    public bool Nullable { get; set; }
}