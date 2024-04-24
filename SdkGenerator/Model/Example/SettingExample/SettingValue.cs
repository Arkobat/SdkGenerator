namespace SdkGenerator.Model.Example.SettingExample;

public class SettingValue<T>
{
    public bool Inherited { get; set; }
    public required T Value { get; set; }
}

public class ToggleableSetting<T> : SettingValue<T>
{
    public bool Enabled { get; set; }
}

public class NullableSettingValue<T>
{
    public bool Inherited { get; set; }
    public T? Value { get; set; }
    public bool HasValue() => Value is not null;
}

public class NullableToggleableSetting<T> : NullableSettingValue<T>
{
    public bool Enabled { get; set; }

    public T? ComputedValue() => Enabled ? Value : default;
}