package sdkgenerator.person;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.NotNull;

import java.util.List;

public class Person {

    @NotNull
    @SerializedName("first_name")
    public String FirstName;

    @NotNull
    @SerializedName("last_name")
    public String lastName;

    @NotNull
    @SerializedName("age")
    public int age;

    @NotNull
    @SerializedName("address")
    public Address address;

    @NotNull
    @SerializedName("jobs")
    public List<Job> jobs;

    public @NotNull String getFirstName() {
        return FirstName;
    }

    public @NotNull String getLastName() {
        return lastName;
    }

    public int getAge() {
        return age;
    }

    public @NotNull Address getAddress() {
        return address;
    }

    public @NotNull List<Job> getJobs() {
        return jobs;
    }
}

