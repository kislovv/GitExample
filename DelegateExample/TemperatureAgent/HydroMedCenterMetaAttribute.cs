namespace DelegateExample.TemperatureAgent;
[AttributeUsage(AttributeTargets.Class| AttributeTargets.Enum)]
public class HydroMedCenterMetaAttribute(string city, string createdAt) : Attribute
{
    public string City { get; set; } = city;
    public DateTime CreatedAt  { get; set; } = DateTime.Parse(createdAt);
}