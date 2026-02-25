using System;
using System.Collections.Generic;

namespace ClassWork;

public class ManagerComparer : IComparer<Manager>
{
    public int Compare(Manager? x, Manager? y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (y is null) return 1;
        if (x is null) return -1;
        var departmentComparison = string.Compare(x.Department, y.Department, StringComparison.Ordinal);
        if(departmentComparison != 0) return departmentComparison;
        
        return x.Salary.CompareTo(y.Salary);
    }
}