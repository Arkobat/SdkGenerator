package ElasticSearch;

import java.time.OffsetDateTime;

import com.fasterxml.jackson.annotation.JsonProperty;

public class DateRange extends Range {
    @JsonProperty("gt")
    private OffsetDateTime greaterThan;

    @JsonProperty("gte")
    private OffsetDateTime greaterThanOrEqualTo;

    @JsonProperty("lt")
    private OffsetDateTime lessThan;

    @JsonProperty("lte")
    private OffsetDateTime lessThanOrEqualTo;

    // Getters and Setters
    // ...
}