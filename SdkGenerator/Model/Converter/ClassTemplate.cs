namespace SdkGenerator.Model.Converter;

public class ClassTemplate
{
    public required string Namespace { get; set; }
    public required List<string> Imports { get; set; }
    public required string Class { get; set; }
    public required List<string> Properties { get; set; }
}

public class ClassTemplate<T> : ClassTemplate
{
    public required T Data { get; set; }
}