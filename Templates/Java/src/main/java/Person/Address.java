package Person;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Address {
    @JsonProperty("street_name")
    private String streetName;

    @JsonProperty("number")
    private int number;

    // Getters and Setters
    public String getStreetName() {
        return streetName;
    }

    public void setStreetName(String streetName) {
        this.streetName = streetName;
    }

    public int getNumber() {
        return number;
    }

    public void setNumber(int number) {
        this.number = number;
    }
}