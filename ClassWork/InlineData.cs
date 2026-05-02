using System;

namespace ClassWork;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class InlineData: Attribute
{
    public object[] Args { get; set; }
    
    public InlineData(params object[] args)
    {
        Args = args;
    }
}