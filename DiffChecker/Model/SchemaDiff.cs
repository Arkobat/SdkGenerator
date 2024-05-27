namespace DiffChecker.Model;

public class ModelDiff
{
    public required DifferenceType Type { get; set; }
    public required string Namespace { get; set; }
    public required string Name { get; set; }
    public required List<Difference> Differences { get; set; } = default!;
    public required List<PropertyDiff> Properties { get; set; } = default!;
}

public class PropertyDiff
{
    public required DifferenceType Type { get; set; }
    public required string Name { get; set; }
    public required List<Difference> Differences { get; set; } = default!;
} 
public class Difference
{
    public required string Path { get; set; } = default!;
    public required string OldValue { get; set; } = default!;
    public required string NewValue { get; set; } = default!;
}

public enum DifferenceType
{
    Added,
    Removed,
    Modified
}