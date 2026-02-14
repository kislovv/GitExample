namespace ReflectionExample;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class MethodVersionAttribute : Attribute
{
    public string Version { get; set; }
    
    public MethodVersionAttribute(string version)
    {
        Version = version;
    }    
}