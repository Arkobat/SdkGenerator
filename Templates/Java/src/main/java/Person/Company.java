package Person;

import com.fasterxml.jackson.annotation.JsonProperty;

public class Company {
    @JsonProperty("name")
    private String name;

    @JsonProperty("address")
    private Address address;

    // Getters and Setters
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Address getAddress() {
        return address;
    }

    public void setAddress(Address address) {
        this.address = address;
    }
}