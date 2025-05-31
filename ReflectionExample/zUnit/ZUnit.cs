using System.Reflection;
using System.Reflection.Metadata;

namespace ReflectionExample.zUnit;

public class ZUnit
{
    public static void Run()
    {
        var ass = Assembly.GetExecutingAssembly();
        var testTypes = ass.GetTypes().Where(t => t.GetCustomAttributes()
            .Any(att => att.GetType() ==  typeof(ZTestAttribute)));
        foreach (var testType in testTypes)
        {
            var testObject = Activator.CreateInstance(testType);
            foreach (var method in testType
                         .GetMethods()
                         .Where(m => m.GetCustomAttributes().Any(att => att.GetType() == typeof(ZFact))))
            {
                ExecuteTest(() => method.Invoke(testObject, null), method.Name);
            }
            foreach (var method in testType
                         .GetMethods()
                         .Where(m => m.GetCustomAttributes().Any(att => att.GetType() == typeof(ZTheory))))
            {
                foreach (var att in method.GetCustomAttributes()
                             .Where(a => a.GetType() == typeof(InlineData)))
                {
                    ExecuteTest(() => method.Invoke(testObject, (att as InlineData)!.Arguments), method.Name);
                }
                
            }
        }
    }

    private static void ExecuteTest(Action execute, string methodName = "")
    {
        try
        {
            execute();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Passed {methodName}");
            Console.ResetColor();
        }
        catch (TargetInvocationException e)
        {
            var inner = e.InnerException;
            Console.ForegroundColor = ConsoleColor.Red;
            switch (inner)
            {
                case null:
                    return;
                case AssertionException:
                    Console.WriteLine($"Failed {methodName} with message: {inner.Message}");
                    break;
                default:
                    Console.WriteLine($"Failed {methodName} with {inner.GetType().Name}: {inner.Message}");
                    break;
            }
            Console.ResetColor();
        }
    }
}