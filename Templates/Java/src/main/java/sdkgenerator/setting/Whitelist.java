package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

import java.util.List;

public class Whitelist {
    public boolean inverted;
    public @NotNull List<String> ids;

    public boolean isInverted() {
        return inverted;
    }

    public @NotNull List<String> getIds() {
        return ids;
    }
}
