package ElasticSearch;

import com.fasterxml.jackson.annotation.JsonProperty;

public class FloatRange extends Range {
    @JsonProperty("gt")
    private Float greaterThan;

    @JsonProperty("gte")
    private Float greaterThanOrEqualTo;

    @JsonProperty("lt")
    private Float lessThan;

    @JsonProperty("lte")
    private Float lessThanOrEqualTo;

    // Getters and Setters
    // ...
}