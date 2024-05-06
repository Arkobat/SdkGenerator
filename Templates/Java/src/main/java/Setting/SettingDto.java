package Setting;

import java.security.Permissions;
import java.util.List;

public class SettingDto extends SimpleSettingDto {
    private String inheritsFrom;
    private int index;
    private String state;
    private boolean active;
    private SettingValue<String> displayName;
    private SettingValue<List<String>> roles;
    private Categories categories;
    private Permissions permissions;
    private Messages messages;
    private Automation automation;
    private Buttons buttons;
    private Limitations limitations;
    private Logging logging;
    private FileSettings files;

    // Getters and Setters
    // ...
}