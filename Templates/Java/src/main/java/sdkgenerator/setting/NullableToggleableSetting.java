package sdkgenerator.setting;

public class NullableToggleableSetting<T> extends NullableSettingValue<T> {
    public boolean enabled;

    public boolean isEnabled() {
        return enabled;
    }
}
