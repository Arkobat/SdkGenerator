namespace SchemaConsumer.Model.Example.SettingExample;

// ReSharper disable PropertyCanBeMadeInitOnly.Global UnusedAutoPropertyAccessor.Global CollectionNeverUpdated.Global ClassNeverInstantiated.Global
public class SimpleSettingDto
{
    public required string SettingId { get; set; } = null!;
    public required string ServerId { get; set; } = null!;
    public required string Name { get; set; } = null!;
}

public class SettingDto : SimpleSettingDto
{
    public required string? InheritsFrom { get; set; }
    public required int Index { get; set; }
    public required string State { get; set; }
    public required bool Active { get; set; }
    public required SettingValue<string> DisplayName { get; set; } = null!;
    public required SettingValue<List<string>> Roles { get; set; }
    public required Categories Categories { get; set; } = null!;
    public required Permissions Permissions { get; set; } = null!;
    public required Messages Messages { get; set; } = null!;
    public required Automation Automation { get; set; } = null!;
    public required Buttons Buttons { get; set; } = null!;
    public required Limitations Limitations { get; set; } = null!;
    public required Logging Logging { get; set; } = null!;
    public required FileSettings Files { get; set; } = null!;
}

public class Categories
{
    public SettingValue<List<SettingCategory>> Queue { get; set; } = null!;
    public SettingValue<List<SettingCategory>> Active { get; set; } = null!;
    public SettingValue<List<SettingCategory>> Done { get; set; } = null!;

    public required SettingValue<bool> AutoMoveAround { get; set; }

    public class SettingCategory
    {
        public string CategoryId { get; set; } = null!;
        public bool SelfCreated { get; set; }
    }
}

public class Permissions
{
    public required SettingValue<PermissionBits> QueuePermissions { get; set; } = null!;
    public required SettingValue<PermissionBits> ActivePermissions { get; set; } = null!;
    public required SettingValue<PermissionBits> DonePermissions { get; set; } = null!;
}

public class PermissionBits
{
    public required ulong Allow { get; set; }
    public required ulong Deny { get; set; }
}

public class Messages
{
    public required NullableToggleableSetting<string> InitialMessage { get; set; }
    public required NullableToggleableSetting<string> CloseMessage { get; set; }
}

public class Automation
{
    public required SettingValue<bool> NotifyUser { get; set; }
    public required SettingValue<bool> RequireCloseReason { get; set; }
    public required SettingValue<bool> NotifyClaimer { get; set; }
    public required SettingValue<bool> CloseOnLeave { get; set; }
    public required ToggleableSetting<TimeSetting> CloseDelay { get; set; }
    public required ToggleableSetting<TimeSetting> AutoCloseWarning { get; set; }
    public required ToggleableSetting<TimeSetting> AutoCloseTime { get; set; }
}

public class Buttons
{
    public required NullableToggleableSetting<ButtonDto> CloseButton { get; set; }
    public required NullableToggleableSetting<ButtonDto> ClaimButton { get; set; }
    public required NullableToggleableSetting<ButtonDto> CancelCloseButton { get; set; }
    public required NullableToggleableSetting<ButtonDto> CloseNowButton { get; set; }
}

public class Limitations
{
    public required ToggleableSetting<int> MaxActivePerUser { get; set; }
    public required ToggleableSetting<int> MaxActiveTotal { get; set; }
    public required ToggleableSetting<TimeSetting> Cooldown { get; set; }
    public SettingValue<Whitelist> Whitelist { get; set; } = null!;
}

public class Whitelist
{
    public required bool Inverted { get; set; }
    public List<string> Ids { get; set; } = null!;
}

public class Logging
{
    public required NullableSettingValue<string> ChannelId { get; set; }
    public required SettingValue<bool> RainbowColors { get; set; }
    public required SettingValue<bool> Created { get; set; }
    public required SettingValue<bool> Claimed { get; set; }
    public required SettingValue<bool> Deleted { get; set; }
    public required SettingValue<bool> MemberAdded { get; set; }
    public required SettingValue<bool> MemberRemoved { get; set; }
    public required SettingValue<bool> SubjectChanged { get; set; }
}

public class FileSettings
{
    public required SettingValue<StorageExceededAction> StorageExceeded { get; set; }
    public required ToggleableSetting<TimeSetting> RetentionTime { get; set; }
}

public enum StorageExceededAction
{
    Reject,
    Inform,
    DeleteOldestFileSameSubject,
    DeleteOldestFileGlobal
}

// ReSharper restore PropertyCanBeMadeInitOnly.Global UnusedAutoPropertyAccessor.Global CollectionNeverUpdated.Global ClassNeverInstantiated.Global