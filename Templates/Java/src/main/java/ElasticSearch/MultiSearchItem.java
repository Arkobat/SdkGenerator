package ElasticSearch;

import com.fasterxml.jackson.annotation.JsonProperty;
import java.util.Map;

public class MultiSearchItem<TDocument> {
    @JsonProperty("fields")
    private Map<String, Object> fields;

    @JsonProperty("hits")
    private Hit<TDocument> hits;

    @JsonProperty("max_score")
    private Double maxScore;

    @JsonProperty("num_reduce_phases")
    private Long numReducePhases;

    @JsonProperty("pit_id")
    private String pitId;

    @JsonProperty("status")
    private Integer status;

    @JsonProperty("terminated_early")
    private Boolean terminatedEarly;

    @JsonProperty("timed_out")
    private boolean timedOut;

    @JsonProperty("took")
    private long took;

    // Getters and Setters
    // ...
}