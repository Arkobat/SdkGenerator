package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

public class SimpleSettingDto {
    @NotNull
    public String settingId;
    @NotNull
    public String serverId;
    @NotNull
    public String name;

    public @NotNull String getSettingId() {
        return settingId;
    }

    public @NotNull String getServerId() {
        return serverId;
    }

    public @NotNull String getName() {
        return name;
    }
}
