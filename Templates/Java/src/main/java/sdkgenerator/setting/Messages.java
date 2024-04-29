package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

public class Messages {
    public @NotNull NullableToggleableSetting<String> initialMessage;
    public @NotNull NullableToggleableSetting<String> closeMessage;

    public @NotNull NullableToggleableSetting<String> getInitialMessage() {
        return initialMessage;
    }

    public @NotNull NullableToggleableSetting<String> getCloseMessage() {
        return closeMessage;
    }
}
