package sdkgenerator.elastic;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.Nullable;

public class LongRange extends Range {
    @Nullable
    @SerializedName("gt")
    public Long greaterThan;

    @Nullable
    @SerializedName("gte")
    public Long greaterThanOrEqualTo;

    @Nullable
    @SerializedName("lt")
    public Long lessThan;

    @Nullable
    @SerializedName("lte")
    public Long lessThanOrEqualTo;

    public @Nullable Long getGreaterThan() {
        return greaterThan;
    }

    public @Nullable Long getGreaterThanOrEqualTo() {
        return greaterThanOrEqualTo;
    }

    public @Nullable Long getLessThan() {
        return lessThan;
    }

    public @Nullable Long getLessThanOrEqualTo() {
        return lessThanOrEqualTo;
    }
}
