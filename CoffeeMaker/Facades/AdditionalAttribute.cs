namespace CoffeeMaker.Facades;

[AttributeUsage(AttributeTargets.Class)]
public class AdditionalAttribute : Attribute
{
    public AdditionalAttribute(AdditionalType additionalType)
    {
        AdditionalType = additionalType;
    }

    public AdditionalType AdditionalType { get; set; }
}