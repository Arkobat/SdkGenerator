package sdkgenerator.elastic;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

import java.util.List;
import java.util.Map;

public class Hit<TDocument> {

    @NotNull
    @SerializedName("fields")
    public Map<String, Object> fields;

    @Nullable
    @SerializedName("highlight")
    public Map<String, List<String>> highlight;

    @NotNull
    @SerializedName("_id")
    public String id;

    @Nullable
    @SerializedName("_ignored")
    public List<String> ignored;

    @NotNull
    @SerializedName("_index")
    public String index;

    @Nullable
    @SerializedName("matched_queries")
    public List<String> matchedQueries;

    @Nullable
    @SerializedName("_node")
    public String node;

    @Nullable
    @SerializedName("_primary_term")
    public Long primaryTerm;

    @Nullable
    @SerializedName("_routing")
    public String routing;

    @Nullable
    @SerializedName("_score")
    public Double score;

    @Nullable
    @SerializedName("_seq_no")
    public Long seqNo;

    @Nullable
    @SerializedName("_shard")
    public String shard;

    @Nullable
    @SerializedName("_source")
    public TDocument source;

    @Nullable
    @SerializedName("_version")
    public Long version;

    public @NotNull Map<String, Object> getFields() {
        return fields;
    }

    public @Nullable Map<String, List<String>> getHighlight() {
        return highlight;
    }

    public @NotNull String getId() {
        return id;
    }

    public @Nullable List<String> getIgnored() {
        return ignored;
    }

    public @NotNull String getIndex() {
        return index;
    }

    public @Nullable List<String> getMatchedQueries() {
        return matchedQueries;
    }

    public @Nullable String getNode() {
        return node;
    }

    public @Nullable Long getPrimaryTerm() {
        return primaryTerm;
    }

    public @Nullable String getRouting() {
        return routing;
    }

    public @Nullable Double getScore() {
        return score;
    }

    public @Nullable Long getSeqNo() {
        return seqNo;
    }

    public @Nullable String getShard() {
        return shard;
    }

    public @Nullable TDocument getSource() {
        return source;
    }

    public @Nullable Long getVersion() {
        return version;
    }
}