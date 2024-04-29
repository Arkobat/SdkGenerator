package sdkgenerator.setting;

import org.jetbrains.annotations.NotNull;

import java.util.List;

public class Categories {
    public @NotNull SettingValue<List<SettingCategory>> queue;
    public @NotNull SettingValue<List<SettingCategory>> active;
    public @NotNull SettingValue<List<SettingCategory>> done;

    public @NotNull SettingValue<Boolean> autoMoveAround;

    public @NotNull SettingValue<List<SettingCategory>> getQueue() {
        return queue;
    }

    public @NotNull SettingValue<List<SettingCategory>> getActive() {
        return active;
    }

    public @NotNull SettingValue<List<SettingCategory>> getDone() {
        return done;
    }

    public @NotNull SettingValue<Boolean> getAutoMoveAround() {
        return autoMoveAround;
    }

    public class SettingCategory {
        public @NotNull String categoryId;
        public boolean selfCreated;

        public @NotNull String getCategoryId() {
            return categoryId;
        }

        public boolean isSelfCreated() {
            return selfCreated;
        }
    }

}
