package sdkgenerator.elastic;

import com.google.gson.annotations.SerializedName;
import org.jetbrains.annotations.NotNull;
import org.jetbrains.annotations.Nullable;

import java.util.List;

public class HitsMetadata<TDocument> {

    @NotNull
    @SerializedName("hits")
    public List<Hit<TDocument>> hits;

    @Nullable
    @SerializedName("max_score")
    public Double maxScore;

    @NotNull
    @SerializedName("total")
    public long total;

    public @NotNull List<Hit<TDocument>> getHits() {
        return hits;
    }

    public @Nullable Double getMaxScore() {
        return maxScore;
    }

    public long getTotal() {
        return total;
    }
}