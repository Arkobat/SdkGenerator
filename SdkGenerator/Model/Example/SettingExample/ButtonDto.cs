namespace SdkGenerator.Model.Example.SettingExample;

public class ButtonDto
{
    public string ButtonId { get; set; } = null!;
    public string? Text { get; set; }
    public string? Url { get; set; }
    public ButtonStyle Style { get; set; }
    public ButtonEmote Emote { get; set; } = null!;
}

public class ButtonEmote
{
    public string? Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public bool Animated { get; set; }
}

public enum ButtonStyle
{
    Primary = 1,
    Secondary = 2,
    Success = 3,
    Danger = 4,
    Link = 5
}