using System.Reflection;

namespace ReflectionExample;

public class SimpleMapper
{
    public static TD Map<TS, TD>(TS source) where TD : new()
    {
        var result = new TD();
        var typeTs = typeof(TS);
        var typeTd = typeof(TD);
        var propertiesTs = typeTs.GetProperties(BindingFlags.Instance | BindingFlags.Public);
        var propertiesTd = typeTd.GetProperties(BindingFlags.Instance | BindingFlags.Public);

        foreach (var propTs in propertiesTs)
        {
            if (!propTs.CanRead || !propTs.CanWrite)
            {
                continue;
            }
            var propertyTd = propertiesTd.FirstOrDefault(propTd => 
                propTd.Name == propTs.Name &&
                propTd.PropertyType == propTs.PropertyType &&
                propTd is { CanWrite: true, CanRead: true });

            propertyTd?.SetValue(result, propTs.GetValue(source));
        }

        return result;
    }
}