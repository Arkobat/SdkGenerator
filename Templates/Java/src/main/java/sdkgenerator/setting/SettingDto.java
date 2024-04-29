package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

import java.util.List;

public class SettingDto extends SimpleSettingDto {
    public @Nullable String inheritsFrom;
    public @NotNull int index;
    public @NotNull String state;
    public @NotNull boolean active;
    public @NotNull SettingValue<String> displayName;
    public @NotNull SettingValue<List<String>> roles;
    public @NotNull Categories categories;
    public @NotNull Permissions permissions;
    public @NotNull Messages messages;
    public @NotNull Automation automation;
    public @NotNull Buttons buttons;
    public @NotNull Limitations limitations;
    public @NotNull Logging logging;
    public @NotNull FileSettings files;

    public @Nullable String getInheritsFrom() {
        return inheritsFrom;
    }

    public int getIndex() {
        return index;
    }

    public @NotNull String getState() {
        return state;
    }

    public boolean isActive() {
        return active;
    }

    public @NotNull SettingValue<String> getDisplayName() {
        return displayName;
    }

    public @NotNull SettingValue<List<String>> getRoles() {
        return roles;
    }

    public @NotNull Categories getCategories() {
        return categories;
    }

    public @NotNull Permissions getPermissions() {
        return permissions;
    }

    public @NotNull Messages getMessages() {
        return messages;
    }

    public @NotNull Automation getAutomation() {
        return automation;
    }

    public @NotNull Buttons getButtons() {
        return buttons;
    }

    public @NotNull Limitations getLimitations() {
        return limitations;
    }

    public @NotNull Logging getLogging() {
        return logging;
    }

    public @NotNull FileSettings getFiles() {
        return files;
    }
}

