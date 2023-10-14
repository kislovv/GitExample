namespace ClassWork.Methods;

internal class Calculator
{
    public static int Sum(int arg1, int arg2)
    {
        return arg1 + arg2;
    }

    public static string Sum(string s1, string s2)
    {
        return s1 + s2;
    }

    public static int[] Sum(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            throw new ArgumentException("Массивы разной длины!");
        }
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] += arr2[i];
        }
        return arr1;
    }
}

