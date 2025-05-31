using System.Reflection;

namespace DllAnalyzer;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new[,] { {1, 2, 3}, { 4, 5, 6}, { 7, 8, 9} };
        var namesOfFiles = Directory.GetFiles("dlls", "*.dll");

        foreach (var name in namesOfFiles)
        {
            var assembly = Assembly.LoadFrom(name);
            var types = assembly.GetTypes().Where(type => typeof(IMatrixMath).IsAssignableFrom(type)
                                                                && !type.IsAbstract
                                                                && !type.IsInterface);
            foreach (var type in types.Where(type => type.GetConstructor(Type.EmptyTypes) != null))
            {
                var matrixMath = Activator.CreateInstance(type) as IMatrixMath;
                Console.WriteLine(matrixMath.GetDeterminant(matrix));
                
            }
            
        }
    }
}