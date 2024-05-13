namespace SchemaExtractor.Model;

public class TypeWrapper(Type type)
{
    public Type Type { get; init; } = type;

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(Type, obj)) return true;
        if (obj is TypeWrapper tw) return Equals(tw.Type);
        if (obj is not Type t) return false;
        return Equals(t);
    }

    public override int GetHashCode()
    {
        return Type.GetHashCode();
    }
    
    public bool Equals(Type other)
    {
        if (other.Name != Type.Name) return false;
        if (other.Namespace != Type.Namespace) return false;
        return true;
    }
}