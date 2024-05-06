package ElasticSearch;

import com.fasterxml.jackson.annotation.JsonProperty;

public class IpAddressRange extends Range {
    @JsonProperty("gt")
    private String greaterThan;

    @JsonProperty("gte")
    private String greaterThanOrEqualTo;

    @JsonProperty("lt")
    private String lessThan;

    @JsonProperty("lte")
    private String lessThanOrEqualTo;

    // Getters and Setters
    // ...
}
