using System.Text;

namespace SchemaConsumer.Extension;

public static class StringBuilderExtensions
{
    public static StringBuilder AppendIf(this StringBuilder sb, bool predicate, string text)
    {
        if (predicate) sb.Append(text);
        return sb;
    }

    public static StringBuilder AppendIf(this StringBuilder sb, Func<bool> predicate, string text)
    {
        return sb.AppendIf(predicate.Invoke(), text);
    }
}