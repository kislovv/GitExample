using System;
namespace ClassWork.Loops;

class Program
{
	static void Main(string[] args)
	{
		string n = "1221";
		Console.WriteLine(IsPalindrom(n));
	}
	static bool IsPalindrom(string n)
	{
		if (n.Length != 4 || !char.IsDigit(n[3]) || !char.IsDigit(n[2]) ||
		!char.IsDigit(n[1]) || !char.IsDigit(n[0]))
		{
			throw new ArgumentException(nameof(n));
		}

		return n[3] == n[0] && n[2] == n[1];
	}
}