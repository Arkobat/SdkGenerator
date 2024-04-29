package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

public class Permissions {
    public @NotNull SettingValue<PermissionBits> queuePermissions;
    public @NotNull SettingValue<PermissionBits> activePermissions;
    public @NotNull SettingValue<PermissionBits> donePermissions;

    public @NotNull SettingValue<PermissionBits> getQueuePermissions() {
        return queuePermissions;
    }

    public @NotNull SettingValue<PermissionBits> getActivePermissions() {
        return activePermissions;
    }

    public @NotNull SettingValue<PermissionBits> getDonePermissions() {
        return donePermissions;
    }
}
