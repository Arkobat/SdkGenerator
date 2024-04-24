namespace SdkGenerator.Extension;

public static class EnumerableExtensions
{
    public static string JoinAsString(this IEnumerable<string> enumerable, string separator)
    {
        return string.Join(separator, enumerable);
    }
}