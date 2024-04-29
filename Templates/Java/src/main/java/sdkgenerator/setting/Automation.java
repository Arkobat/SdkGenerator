package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

public class Automation {
    public @NotNull SettingValue<Boolean> notifyUser;
    public @NotNull SettingValue<Boolean> requireCloseReason;
    public @NotNull SettingValue<Boolean> notifyClaimer;
    public @NotNull SettingValue<Boolean> closeOnLeave;
    public @NotNull ToggleableSetting<TimeSetting> closeDelay;
    public @NotNull ToggleableSetting<TimeSetting> autoCloseWarning;
    public @NotNull ToggleableSetting<TimeSetting> autoCloseTime;

    public @NotNull SettingValue<Boolean> getNotifyUser() {
        return notifyUser;
    }

    public @NotNull SettingValue<Boolean> getRequireCloseReason() {
        return requireCloseReason;
    }

    public @NotNull SettingValue<Boolean> getNotifyClaimer() {
        return notifyClaimer;
    }

    public @NotNull SettingValue<Boolean> getCloseOnLeave() {
        return closeOnLeave;
    }

    public @NotNull ToggleableSetting<TimeSetting> getCloseDelay() {
        return closeDelay;
    }

    public @NotNull ToggleableSetting<TimeSetting> getAutoCloseWarning() {
        return autoCloseWarning;
    }

    public @NotNull ToggleableSetting<TimeSetting> getAutoCloseTime() {
        return autoCloseTime;
    }
}
