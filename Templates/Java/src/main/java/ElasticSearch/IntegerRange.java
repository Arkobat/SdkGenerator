package ElasticSearch;

import com.fasterxml.jackson.annotation.JsonProperty;

public class IntegerRange extends Range {
    @JsonProperty("gt")
    private Integer greaterThan;

    @JsonProperty("gte")
    private Integer greaterThanOrEqualTo;

    @JsonProperty("lt")
    private Integer lessThan;

    @JsonProperty("lte")
    private Integer lessThanOrEqualTo;

    // Getters and Setters
    // ...
}
