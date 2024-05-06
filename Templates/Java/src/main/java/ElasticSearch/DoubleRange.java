package ElasticSearch;

import com.fasterxml.jackson.annotation.JsonProperty;

public class DoubleRange extends Range {
    @JsonProperty("gt")
    private Double greaterThan;

    @JsonProperty("gte")
    private Double greaterThanOrEqualTo;

    @JsonProperty("lt")
    private Double lessThan;

    @JsonProperty("lte")
    private Double lessThanOrEqualTo;

    // Getters and Setters
    // ...
}
