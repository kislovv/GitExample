namespace ReflectionExample;

[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
public class EnumDescriptionAttribute(string description) : Attribute
{
    public string Description { get; set; } = description;
}