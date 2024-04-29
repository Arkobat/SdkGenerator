package sdkgenerator.elastic;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.Nullable;

public class DoubleRange extends Range {
    @Nullable
    @SerializedName("gt")
    public Double greaterThan;

    @Nullable
    @SerializedName("gte")
    public Double greaterThanOrEqualTo;

    @Nullable
    @SerializedName("lt")
    public Double lessThan;

    @Nullable
    @SerializedName("lte")
    public Double lessThanOrEqualTo;

    public @Nullable Double getGreaterThan() {
        return greaterThan;
    }

    public @Nullable Double getGreaterThanOrEqualTo() {
        return greaterThanOrEqualTo;
    }

    public @Nullable Double getLessThan() {
        return lessThan;
    }

    public @Nullable Double getLessThanOrEqualTo() {
        return lessThanOrEqualTo;
    }
}
