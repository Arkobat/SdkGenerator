using System.Text.Json.Serialization;

namespace SdkGenerator.Model.Example.PersonExample;

public class Person
{
    [JsonPropertyName("first_name")] public required string FirstName { get; set; }
    [JsonPropertyName("last_name")] public required string LastName { get; set; }
    [JsonPropertyName("age")] public required int Age { get; set; }
    [JsonPropertyName("address")] public required Address Address { get; set; }
    [JsonPropertyName("jobs")] public required List<Job> Jobs { get; set; }
    [JsonPropertyName("parent")] public Person? Parent { get; set; }
    [JsonPropertyName("child")] public Person? Child { get; set; }
}