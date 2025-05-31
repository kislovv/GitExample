using System.ComponentModel;

namespace ReflectionExample.zUnit;

[AttributeUsage(AttributeTargets.Method)]
public class ZTheory : Attribute
{
    
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class InlineData(params object[] arguments) : Attribute
{
    public object[] Arguments { get; } = arguments;
}