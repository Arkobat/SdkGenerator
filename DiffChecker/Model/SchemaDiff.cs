namespace DiffChecker.Model;

public class Difference<T>
{
    public DifferenceType Type { get; set; }
    public string Path { get; set; } = default!;
    public T Value { get; set; } = default!;
}

public enum DifferenceType
{
    Added,
    Removed,
    Modified
}