namespace SchemaConsumer.Model.Example.SettingExample;

public class TimeSetting
{
    public long Time { get; set; }
    public TimeUnit TimeUnit { get; set; }

    public long TotalSeconds() => Time * (int) TimeUnit;
}

public enum TimeUnit
{
    Second = 1,
    Minute = Second * 60,
    Hour = Minute * 60,
    Day = Hour * 24
}