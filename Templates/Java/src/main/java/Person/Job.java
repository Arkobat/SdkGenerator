package Person;

import com.fasterxml.jackson.annotation.JsonProperty;
import java.time.LocalDate;

public class Job {
    @JsonProperty("title")
    private String title;

    @JsonProperty("company")
    private Company company;

    @JsonProperty("started_at")
    private LocalDate startedAt;

    // Getters and Setters
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public Company getCompany() {
        return company;
    }

    public void setCompany(Company company) {
        this.company = company;
    }

    public LocalDate getStartedAt() {
        return startedAt;
    }

    public void setStartedAt(LocalDate startedAt) {
        this.startedAt = startedAt;
    }
}
