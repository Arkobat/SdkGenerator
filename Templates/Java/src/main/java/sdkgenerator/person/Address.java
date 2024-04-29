package sdkgenerator.person;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.NotNull;

public class Address {

    @NotNull
    @SerializedName("street_name")
    public String streetName;

    @SerializedName("number")
    public int number;

    public @NotNull String getStreetName() {
        return streetName;
    }

    public int getNumber() {
        return number;
    }

}