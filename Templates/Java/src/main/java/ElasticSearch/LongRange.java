package ElasticSearch;

import com.fasterxml.jackson.annotation.JsonProperty;

public class LongRange extends Range {
    @JsonProperty("gt")
    private Long greaterThan;

    @JsonProperty("gte")
    private Long greaterThanOrEqualTo;

    @JsonProperty("lt")
    private Long lessThan;

    @JsonProperty("lte")
    private Long lessThanOrEqualTo;

    // Getters and Setters
    // ...
}