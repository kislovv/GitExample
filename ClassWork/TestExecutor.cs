using System;
using System.Linq;
using System.Reflection;

namespace ClassWork;

public class TestExecutor
{
    public static void ExecuteAllTests()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        Type[] types = assembly.GetTypes().Where(
            t => t.GetMethods()
                .Any(m => m.GetCustomAttributes<Fact>().Any())).ToArray();

        foreach (Type type in types)
        {
            var t = Activator.CreateInstance(type);
            foreach (MethodInfo method in type.GetMethods())
            {
                if (method.GetCustomAttributes<Fact>().Any())
                {
                    try
                    {
                        method.Invoke(t, Array.Empty<object>());
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"{method.Name}: PASSED");
                    }
                    catch (TargetInvocationException e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{method.Name}: {e.InnerException!.Message}");
                    }
                    finally
                    {
                        Console.ResetColor();
                    }
                }
            }
        }

    }
}