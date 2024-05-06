package ElasticSearch;

import com.fasterxml.jackson.annotation.JsonProperty;
import java.util.Collection;

public class HitsMetadata<TDocument> {
    @JsonProperty("hits")
    private Collection<Hit<TDocument>> hits;

    @JsonProperty("max_score")
    private Double maxScore;

    @JsonProperty("total")
    private long total;

    // Getters and Setters
    public Collection<Hit<TDocument>> getHits() {
        return hits;
    }

    public void setHits(Collection<Hit<TDocument>> hits) {
        this.hits = hits;
    }

    public Double getMaxScore() {
        return maxScore;
    }

    public void setMaxScore(Double maxScore) {
        this.maxScore = maxScore;
    }

    public long getTotal() {
        return total;
    }

    public void setTotal(long total) {
        this.total = total;
    }
}
