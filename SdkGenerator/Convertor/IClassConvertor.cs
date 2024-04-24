namespace SdkGenerator.Convertor;

public interface IClassConvertor : IConvertor
{
    public string ClassTemplate();

    public string Property(Property property);

    public string Constructor(string className, List<Property> properties);
}

public class Property
{
    public required string Name { get; set; }
    public required string Type { get; set; }
    public required bool Required { get; set; }
    public required bool Nullable { get; set; }
}