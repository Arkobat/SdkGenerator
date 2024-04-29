package sdkgenerator.person;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.NotNull;

import java.util.Date;

public class Job {

    @NotNull
    @SerializedName("title")
    public String title;

    @NotNull
    @SerializedName("company")
    public Company company;


    @NotNull
    @SerializedName("started_at")
    public Date startedAt;

    public @NotNull String getTitle() {
        return title;
    }

    public sdkgenerator.person.@NotNull Company getCompany() {
        return company;
    }

    public @NotNull Date getStartedAt() {
        return startedAt;
    }
}