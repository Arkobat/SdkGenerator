package sdkgenerator.setting;

import org.jetbrains.annotations.Nullable;

public class NullableSettingValue<T> {
    public boolean inherited;
    @Nullable
    public T Value;

    public boolean isInherited() {
        return inherited;
    }

    public @Nullable T getValue() {
        return Value;
    }
}
