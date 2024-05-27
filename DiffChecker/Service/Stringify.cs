namespace DiffChecker.Service;

public static class Stringify
{
    public static string ToString(bool? b) => b.HasValue ? b.Value.ToString() : "null";
    public static string ToString<T>(List<T>? l) => l is null ? "null" : $"[{string.Join(", ", l)}]";
    public static string ToString<T>(T? t) => (t is null ? "null" : t.ToString())!;
}