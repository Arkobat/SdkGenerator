package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

public class Logging {
    public @NotNull NullableSettingValue<String> channelId;
    public @NotNull SettingValue<Boolean> rainbowColors;
    public @NotNull SettingValue<Boolean> created;
    public @NotNull SettingValue<Boolean> claimed;
    public @NotNull SettingValue<Boolean> deleted;
    public @NotNull SettingValue<Boolean> memberAdded;
    public @NotNull SettingValue<Boolean> memberRemoved;
    public @NotNull SettingValue<Boolean> subjectChanged;

    public @NotNull NullableSettingValue<String> getChannelId() {
        return channelId;
    }

    public @NotNull SettingValue<Boolean> getRainbowColors() {
        return rainbowColors;
    }

    public @NotNull SettingValue<Boolean> getCreated() {
        return created;
    }

    public @NotNull SettingValue<Boolean> getClaimed() {
        return claimed;
    }

    public @NotNull SettingValue<Boolean> getDeleted() {
        return deleted;
    }

    public @NotNull SettingValue<Boolean> getMemberAdded() {
        return memberAdded;
    }

    public @NotNull SettingValue<Boolean> getMemberRemoved() {
        return memberRemoved;
    }

    public @NotNull SettingValue<Boolean> getSubjectChanged() {
        return subjectChanged;
    }
}
