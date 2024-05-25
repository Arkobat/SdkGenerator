using System.Text.Json.Serialization;

namespace SchemaConsumer.Model.Example.PersonExample;

public class Address
{
    [JsonPropertyName("street_name")] public required string StreetName { get; set; }
    [JsonPropertyName("number")] public required int Number { get; set; }
}