package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

public class ButtonDto {
    public @NotNull String ButtonId;
    public @Nullable String Text;
    public @Nullable String Url;
    public @NotNull ButtonStyle Style;
    public @NotNull ButtonEmote Emote;

    public @NotNull String getButtonId() {
        return ButtonId;
    }

    public @Nullable String getText() {
        return Text;
    }

    public @Nullable String getUrl() {
        return Url;
    }

    public @NotNull ButtonStyle getStyle() {
        return Style;
    }

    public @NotNull ButtonEmote getEmote() {
        return Emote;
    }
}

