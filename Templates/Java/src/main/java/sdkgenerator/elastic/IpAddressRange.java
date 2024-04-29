package sdkgenerator.elastic;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.Nullable;

public class IpAddressRange extends Range {
    @Nullable
    @SerializedName("gt")
    public String greaterThan;

    @Nullable
    @SerializedName("gte")
    public String greaterThanOrEqualTo;

    @Nullable
    @SerializedName("lt")
    public String lessThan;

    @Nullable
    @SerializedName("lte")
    public String lessThanOrEqualTo;

    public @Nullable String getGreaterThan() {
        return greaterThan;
    }

    public @Nullable String getGreaterThanOrEqualTo() {
        return greaterThanOrEqualTo;
    }

    public @Nullable String getLessThan() {
        return lessThan;
    }

    public @Nullable String getLessThanOrEqualTo() {
        return lessThanOrEqualTo;
    }
}
