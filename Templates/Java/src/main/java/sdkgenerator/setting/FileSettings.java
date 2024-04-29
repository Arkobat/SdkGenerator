package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

public class FileSettings {
    public @NotNull SettingValue<StorageExceededAction> storageExceeded;
    public @NotNull ToggleableSetting<TimeSetting> retentionTime;

    public @NotNull SettingValue<StorageExceededAction> getStorageExceeded() {
        return storageExceeded;
    }

    public @NotNull ToggleableSetting<TimeSetting> getRetentionTime() {
        return retentionTime;
    }
}
