package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

public class SettingValue<T> {
    public boolean inherited;

    @NotNull
    public T value;

    public boolean isInherited() {
        return inherited;
    }

    public T getValue() {
        return value;
    }
}

