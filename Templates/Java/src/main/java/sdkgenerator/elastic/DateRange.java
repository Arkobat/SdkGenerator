package sdkgenerator.elastic;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.Nullable;

import java.time.OffsetDateTime;

public class DateRange extends Range {
    @Nullable
    @SerializedName("gt")
    public OffsetDateTime greaterThan;

    @Nullable
    @SerializedName("gte")
    public OffsetDateTime greaterThanOrEqualTo;

    @Nullable
    @SerializedName("lt")
    public OffsetDateTime lessThan;

    @Nullable
    @SerializedName("lte")
    public OffsetDateTime lessThanOrEqualTo;

    public @Nullable OffsetDateTime getGreaterThan() {
        return greaterThan;
    }

    public @Nullable OffsetDateTime getGreaterThanOrEqualTo() {
        return greaterThanOrEqualTo;
    }

    public @Nullable OffsetDateTime getLessThan() {
        return lessThan;
    }

    public @Nullable OffsetDateTime getLessThanOrEqualTo() {
        return lessThanOrEqualTo;
    }
}
