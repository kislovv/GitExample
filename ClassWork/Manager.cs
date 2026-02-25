using System;
using System.Collections;

namespace ClassWork;

public class Manager : Employee
{
    public string Department { get; set; }

    public override bool Equals(object? obj)
    {
        if(obj is null) return false;
        if(obj.GetType() != GetType()) return false;
        Manager x = (Manager)obj;
        
        return x.Department == Department && 
               x.Salary == Salary &&
               x.Name == Name;
        
        
        return base.Equals(obj);
    }


    override public int GetHashCode()
    {
        return HashCode.Combine(Department, Salary, Name);
    }
}