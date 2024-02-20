namespace SdkGenerator.Model;

public class ClassTemplate
{
    public required string Namespace { get; set; }
    public required List<string> Imports { get; set; }
    public required bool Abstract { get; set; }
    public required bool Interface { get; set; }
    public required string ClassName { get; set; }
//    public required List<ClassTemplate> Generics { get; set; }
    public required List<Property> Properties { get; set; }
}

public class Property
{
    [SdkType<string>]
    public required string Type { get; set; }
    public required string Name { get; set; }

    public string FormattedType => GetFormattedType();

    private string GetFormattedType()
    {
        return PropertyType.String switch
        {
            PropertyType.Bool => "bool",
            PropertyType.Byte => "byte",
            PropertyType.Short => "short",
            PropertyType.Int => "int",
            PropertyType.Long => "long",
            PropertyType.Float => "float",
            PropertyType.Double => "double",
            PropertyType.String => "string",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}

public enum PropertyType
{
    Bool,
    Byte,
    Short,
    Int,
    Long,
    Float,
    Double,
    String
}