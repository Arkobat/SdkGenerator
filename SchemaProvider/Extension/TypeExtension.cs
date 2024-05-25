using System.Reflection;

namespace SchemaExtractor.Extension;

public static class TypeExtension
{
    public static bool IsNullable(this Type type)
    {
        return Nullable.GetUnderlyingType(type) != null;
    }

    public static bool IsNullable(this PropertyInfo type)
    {
        //return Nullable.GetUnderlyingType(type) != null;
        return new NullabilityInfoContext().Create(type).WriteState is NullabilityState.Nullable;
    }
}