package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

public class Buttons {
    public @NotNull NullableToggleableSetting<ButtonDto> closeButton;
    public @NotNull NullableToggleableSetting<ButtonDto> claimButton;
    public @NotNull NullableToggleableSetting<ButtonDto> cancelCloseButton;
    public @NotNull NullableToggleableSetting<ButtonDto> closeNowButton;

    public @NotNull NullableToggleableSetting<ButtonDto> getCloseButton() {
        return closeButton;
    }

    public @NotNull NullableToggleableSetting<ButtonDto> getClaimButton() {
        return claimButton;
    }

    public @NotNull NullableToggleableSetting<ButtonDto> getCancelCloseButton() {
        return cancelCloseButton;
    }

    public @NotNull NullableToggleableSetting<ButtonDto> getCloseNowButton() {
        return closeNowButton;
    }
}
