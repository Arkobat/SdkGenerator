namespace SchemaConsumer.Model.Definition;

public class DiffOptions
{
    public WarnLevel TypeAdded { get; set; } = WarnLevel.Error;
    public WarnLevel TypeRemoved { get; set; } = WarnLevel.Error;
    public WarnLevel PropertyAdded { get; set; } = WarnLevel.Error;
    public WarnLevel PropertyRemoved { get; set; } = WarnLevel.Error;
    public WarnLevel NullabilityChanged { get; set; } = WarnLevel.Error;
}