using System.Text.Json.Serialization;

namespace SchemaConsumer.Model.Example.ElasticSearch;

public class MultiSearchItem<TDocument>
{
    [JsonPropertyName("fields")] public IReadOnlyDictionary<string, object>? Fields { get; init; }

    [JsonPropertyName("hits")] public Hit<TDocument> Hits { get; init; }

    [JsonPropertyName("max_score")] public double? MaxScore { get; init; }

    [JsonPropertyName("num_reduce_phases")] public long? NumReducePhases { get; init; }

    [JsonPropertyName("pit_id")] public string? PitId { get; init; }

    [JsonPropertyName("status")] public int? Status { get; init; }

    [JsonPropertyName("terminated_early")] public bool? TerminatedEarly { get; init; }

    [JsonPropertyName("timed_out")] public bool TimedOut { get; init; }

    [JsonPropertyName("took")] public long Took { get; init; }
}
