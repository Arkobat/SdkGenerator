using System.Text.Json.Serialization;

namespace SchemaConsumer.Model.Example.PersonExample;

public class Company
{
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("address")] public required Address Address { get; set; }
}