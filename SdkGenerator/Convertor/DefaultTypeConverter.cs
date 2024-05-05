namespace SdkGenerator.Convertor;

public class DefaultTypeConverter
{
    public static bool IsNative<T>(out string? type) => IsNative(typeof(T), out type);

    public static bool IsNative(Type t, out string? type)
    {
        if (t == typeof(bool))
        {
            type = "bool";
            return true;
        }

        if (t == typeof(byte))
        {
            type = "int8";
            return true;
        }

        if (t == typeof(short))
        {
            type = "int16";
            return true;
        }

        if (t == typeof(ushort))
        {
            type = "int16";
            return true;
        }

        if (t == typeof(int))
        {
            type = "int32";
            return true;
        }

        if (t == typeof(uint))
        {
            type = "int32";
            return true;
        }

        if (t == typeof(long))
        {
            type = "int64";
            return true;
        }

        if (t == typeof(ulong))
        {
            type = "int64";
            return true;
        }

        if (t == typeof(float))
        {
            type = "float";
            return true;
        }

        if (t == typeof(double))
        {
            type = "double";
            return true;
        }

        if (t == typeof(string))
        {
            type = "string";
            return true;
        }

        if (t == typeof(Guid))
        {
            type = "guid";
            return true;
        }

        type = null;
        return false;
    }
}