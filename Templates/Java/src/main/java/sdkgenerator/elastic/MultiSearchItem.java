package sdkgenerator.elastic;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

import java.util.Map;

public class MultiSearchItem<TDocument> {

    @Nullable
    @SerializedName("fields")
    public Map<String, Object> fields;

    @NotNull
    @SerializedName("hits")
    public Hit<TDocument> hits;

    @Nullable
    @SerializedName("max_score")
    public Double maxScore;

    @Nullable
    @SerializedName("num_reduce_phases")
    public Long numReducePhases;

    @Nullable
    @SerializedName("pit_id")
    public String pitId;

    @Nullable
    @SerializedName("status")
    public Integer status;

    @Nullable
    @SerializedName("terminated_early")
    public Boolean terminatedEarly;

    @Nullable
    @SerializedName("timed_out")
    public Boolean timedOut;

    @NotNull
    @SerializedName("took")
    public long took;

    public @Nullable Map<String, Object> getFields() {
        return fields;
    }

    public @NotNull Hit<TDocument> getHits() {
        return hits;
    }

    public @Nullable Double getMaxScore() {
        return maxScore;
    }

    public @Nullable Long getNumReducePhases() {
        return numReducePhases;
    }

    public @Nullable String getPitId() {
        return pitId;
    }

    public @Nullable Integer getStatus() {
        return status;
    }

    public @Nullable Boolean getTerminatedEarly() {
        return terminatedEarly;
    }

    public @Nullable Boolean getTimedOut() {
        return timedOut;
    }

    public long getTook() {
        return took;
    }
}
    
