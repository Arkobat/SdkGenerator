package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

public class ButtonEmote {
    public @Nullable String Id;
    public @NotNull String Name;
    public boolean Animated;

    public @Nullable String getId() {
        return Id;
    }

    public @NotNull String getName() {
        return Name;
    }

    public boolean isAnimated() {
        return Animated;
    }
}
