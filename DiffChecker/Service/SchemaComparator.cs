using SchemaConsumer.Shared.Model;

namespace DiffChecker.Service;

public class SchemaComparator : IEqualityComparer<Schema>
{
    public bool Equals(Schema? x, Schema? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null)) return false;
        if (ReferenceEquals(y, null)) return false;
        if (x.GetType() != y.GetType()) return false;
        return x.Type == y.Type &&
               x.Namespace == y.Namespace &&
               x.Name == y.Name;
    }

    public int GetHashCode(Schema obj)
    {
        return HashCode.Combine((int) obj.Type, obj.Namespace, obj.Name);
    }
}

public class PropertyComparer : IEqualityComparer<SchemaProperty>
{
    public bool Equals(SchemaProperty? x, SchemaProperty? y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null)) return false;
        if (ReferenceEquals(y, null)) return false;
        return x.Name == y.Name;
    }

    public int GetHashCode(SchemaProperty obj)
    {
        return HashCode.Combine(obj.Name);
    }
}