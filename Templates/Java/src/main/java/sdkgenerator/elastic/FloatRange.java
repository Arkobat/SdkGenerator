package sdkgenerator.elastic;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.Nullable;

public class FloatRange extends Range {
    @Nullable
    @SerializedName("gt")
    public Float greaterThan;

    @Nullable
    @SerializedName("gte")
    public Float greaterThanOrEqualTo;

    @Nullable
    @SerializedName("lt")
    public Float lessThan;

    @Nullable
    @SerializedName("lte")
    public Float lessThanOrEqualTo;

    public @Nullable Float getGreaterThan() {
        return greaterThan;
    }

    public @Nullable Float getGreaterThanOrEqualTo() {
        return greaterThanOrEqualTo;
    }

    public @Nullable Float getLessThan() {
        return lessThan;
    }

    public @Nullable Float getLessThanOrEqualTo() {
        return lessThanOrEqualTo;
    }
}
