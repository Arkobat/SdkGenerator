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
    /// <param name="property"></param>
    /// <returns></returns>
    public string Property(Property property);

    public string Constructor(string className, IEnumerable<Property> properties);
}

public class Property
{
    public required string Name { get; set; }
    public required string Type { get; set; }
    public required bool Required { get; set; }
    public required bool Nullable { get; set; }
}