package sdkgenerator.setting;

public class ToggleableSetting<T> extends SettingValue<T> {
    public boolean enabled;

    public boolean isEnabled() {
        return enabled;
    }
}
