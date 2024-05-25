namespace SchemaExtractor.Extension;

public static class EnumerableExtension
{
    public static List<T>? ToNullableList<T>(this IEnumerable<T> enumerable)
    {
        var list = enumerable.ToList();
        return list.Count != 0 ? list : null;
    }
}