namespace ClassWork;

public class EmployeeMapper
{
    public static TDestEmployee ChangeWork<TSourceEmployee, TDestEmployee>(TSourceEmployee source, decimal newSalary)
        where TSourceEmployee : Employee
        where TDestEmployee : Employee , new()
    {
        TDestEmployee result = new TDestEmployee();
        result.Company = source.Company;
        result.Salary = newSalary;
        result.Name = source.Name;
        result.Exp = 0;
        
        return result;
    }
}