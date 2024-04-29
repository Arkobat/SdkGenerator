package sdkgenerator.setting;

public class UpdateSettingDto<T> {
    public String path;
    public T value;
    public Operation operation;

    public UpdateSettingDto(String path, T value, Operation operation) {
        this.path = path;
        this.value = value;
        this.operation = operation;
    }

    public String getPath() {
        return path;
    }

    public T getValue() {
        return value;
    }

    public Operation getOperation() {
        return operation;
    }
}

