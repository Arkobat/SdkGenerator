using System.Text.Json.Serialization;

namespace SchemaConsumer.Model.Example.ElasticSearch;

public abstract class Range;

public class DateRange : Range
{
    [JsonPropertyName("gt")] public DateTimeOffset? GreaterThan { get; set; }
    [JsonPropertyName("gte")] public DateTimeOffset? GreaterThanOrEqualTo { get; set; }
    [JsonPropertyName("lt")] public DateTimeOffset? LessThan { get; set; }
    [JsonPropertyName("lte")] public DateTimeOffset? LessThanOrEqualTo { get; set; }
}

public class DoubleRange : Range
{
    [JsonPropertyName("gt")] public double? GreaterThan { get; set; }
    [JsonPropertyName("gte")] public double? GreaterThanOrEqualTo { get; set; }
    [JsonPropertyName("lt")] public double? LessThan { get; set; }
    [JsonPropertyName("lte")] public double? LessThanOrEqualTo { get; set; }
}

public class FloatRange : Range
{
    [JsonPropertyName("gt")] public float? GreaterThan { get; set; }
    [JsonPropertyName("gte")] public float? GreaterThanOrEqualTo { get; set; }
    [JsonPropertyName("lt")] public float? LessThan { get; set; }
    [JsonPropertyName("lte")] public float? LessThanOrEqualTo { get; set; }
}

public class IntegerRange : Range
{
    [JsonPropertyName("gt")] public int? GreaterThan { get; set; }
    [JsonPropertyName("gte")] public int? GreaterThanOrEqualTo { get; set; }
    [JsonPropertyName("lt")] public int? LessThan { get; set; }
    [JsonPropertyName("lte")] public int? LessThanOrEqualTo { get; set; }
}

public class LongRange : Range
{
    [JsonPropertyName("gt")] public long? GreaterThan { get; set; }
    [JsonPropertyName("gte")] public long? GreaterThanOrEqualTo { get; set; }
    [JsonPropertyName("lt")] public long? LessThan { get; set; }
    [JsonPropertyName("lte")] public long? LessThanOrEqualTo { get; set; }
}

public class IpAddressRange : Range
{
    [JsonPropertyName("gt")] public string? GreaterThan { get; set; }
    [JsonPropertyName("gte")] public string? GreaterThanOrEqualTo { get; set; }
    [JsonPropertyName("lt")] public string? LessThan { get; set; }
    [JsonPropertyName("lte")] public string? LessThanOrEqualTo { get; set; }
}