package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

public class Limitations {
    public @NotNull ToggleableSetting<Integer> maxActivePerUser;
    public @NotNull ToggleableSetting<Integer> maxActiveTotal;
    public @NotNull ToggleableSetting<TimeSetting> cooldown;
    public @NotNull SettingValue<Whitelist> whitelist;

    public @NotNull ToggleableSetting<Integer> getMaxActivePerUser() {
        return maxActivePerUser;
    }

    public @NotNull ToggleableSetting<Integer> getMaxActiveTotal() {
        return maxActiveTotal;
    }

    public @NotNull ToggleableSetting<TimeSetting> getCooldown() {
        return cooldown;
    }

    public @NotNull SettingValue<Whitelist> getWhitelist() {
        return whitelist;
    }
}
