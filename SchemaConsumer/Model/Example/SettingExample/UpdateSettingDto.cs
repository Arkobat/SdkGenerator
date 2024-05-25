namespace SchemaConsumer.Model.Example.SettingExample;

public class UpdateSettingDto<T>
{
    public required string Path { get; set; }
    public required T Value { get; set; }
    public required Operation Operation { get; set; }
}

public enum Operation
{
    Set,
    Add,
    Remove
}