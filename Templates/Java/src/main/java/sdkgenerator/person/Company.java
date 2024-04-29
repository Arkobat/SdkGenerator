package sdkgenerator.person;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.NotNull;

public class Company {

    @NotNull
    @SerializedName("name")
    public String name;

    @NotNull
    @SerializedName("address")
    public Address address;

    public @NotNull String getName() {
        return name;
    }

    public @NotNull Address getAddress() {
        return address;
    }
}