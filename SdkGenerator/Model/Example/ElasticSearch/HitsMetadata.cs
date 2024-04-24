using System.Text.Json.Serialization;

namespace SdkGenerator.Model.Example.ElasticSearch;

public class HitsMetadata<TDocument>
{
    [JsonPropertyName("hits")]
    public IReadOnlyCollection<Hit<TDocument>> Hits { get; init; }

    [JsonPropertyName("max_score")] public double? MaxScore { get; init; }

    [JsonPropertyName("total")]
    public long Total { get; init; }
}