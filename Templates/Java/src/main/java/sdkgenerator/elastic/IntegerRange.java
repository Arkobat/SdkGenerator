package sdkgenerator.elastic;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.Nullable;

public class IntegerRange extends Range {
    @Nullable
    @SerializedName("gt")
    public Integer greaterThan;

    @Nullable
    @SerializedName("gte")
    public Integer greaterThanOrEqualTo;

    @Nullable
    @SerializedName("lt")
    public Integer lessThan;

    @Nullable
    @SerializedName("lte")
    public Integer lessThanOrEqualTo;

    public @Nullable Integer getGreaterThan() {
        return greaterThan;
    }

    public @Nullable Integer getGreaterThanOrEqualTo() {
        return greaterThanOrEqualTo;
    }

    public @Nullable Integer getLessThan() {
        return lessThan;
    }

    public @Nullable Integer getLessThanOrEqualTo() {
        return lessThanOrEqualTo;
    }
}
