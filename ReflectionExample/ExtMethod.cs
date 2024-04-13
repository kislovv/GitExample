using System.Reflection;

namespace ReflectionExample;

public static class ExtMethod
{
    public static string EnumToStringConvert<T>(this T input) where T : Enum
    {
        var typeOfEnum = input.GetType();
        var enumMember = typeOfEnum.GetMember(input.ToString());
        var result = enumMember[0].GetCustomAttribute<EnumDescriptionAttribute>();

        return result?.Description ?? input.ToString();
    }
}