using System.Text.Json.Serialization;

namespace SdkGenerator.Model.Example.PersonExample;

public class Job
{
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("company")] public required Company Company { get; set; }
    [JsonPropertyName("started_at")] public required DateOnly StartedAt { get; set; }
}