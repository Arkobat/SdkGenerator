package ElasticSearch;

import com.fasterxml.jackson.annotation.JsonProperty;
import java.util.Map;
import java.util.Collection;

public class Hit<TDocument> {
    @JsonProperty("fields")
    private Map<String, Object> fields;

    @JsonProperty("highlight")
    private Map<String, Collection<String>> highlight;

    @JsonProperty("_id")
    private String id;

    @JsonProperty("_ignored")
    private Collection<String> ignored;

    @JsonProperty("_index")
    private String index;

    @JsonProperty("matched_queries")
    private Collection<String> matchedQueries;

    @JsonProperty("_node")
    private String node;

    @JsonProperty("_primary_term")
    private Long primaryTerm;

    @JsonProperty("_routing")
    private String routing;

    @JsonProperty("_score")
    private Double score;

    @JsonProperty("_seq_no")
    private Long seqNo;

    @JsonProperty("_shard")
    private String shard;

    @JsonProperty("_source")
    private TDocument source;

    @JsonProperty("_version")
    private Long version;

    // Getters and Setters
    // ...
}
