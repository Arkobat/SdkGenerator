using System.Text.Json.Serialization;

namespace SchemaConsumer.Model.Example.ElasticSearch;

public class Hit<TDocument>
{
    [JsonPropertyName("fields")] 
    public IReadOnlyDictionary<string, object>? Fields { get; init; }
    
    [JsonPropertyName("highlight")] 
    public IReadOnlyDictionary<string, IReadOnlyCollection<string>>? Highlight { get; init; }
    
    [JsonPropertyName("_id")] 
    public string Id { get; init; }
    
    [JsonPropertyName("_ignored")] 
    public IReadOnlyCollection<string>? Ignored { get; init; }
    
    [JsonPropertyName("_index")] 
    public string Index { get; init; }
    
    [JsonPropertyName("matched_queries")] 
    public IReadOnlyCollection<string>? MatchedQueries { get; init; }
    
    [JsonPropertyName("_node")] 
    public string? Node { get; init; }
    
    [JsonPropertyName("_primary_term")] 
    public long? PrimaryTerm { get; init; }
    
    [JsonPropertyName("_routing")] 
    public string? Routing { get; init; }
    
    [JsonPropertyName("_score")] 
    public double? Score { get; init; }
    
    [JsonPropertyName("_seq_no")] 
    public long? SeqNo { get; init; }
    
    [JsonPropertyName("_shard")] 
    public string? Shard { get; init; }
    
    [JsonPropertyName("_source")] 
    public TDocument? Source { get; init; }
    
    [JsonPropertyName("_version")] 
    public long? Version { get; init; }
}