using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassWork.Loops;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine(MaskingCard("1234 5678 9012 3456"));

		Console.WriteLine(string.Join("\n", 
			GetAllNumsInString("Товар стоит 1500 рублей, скидка 20%")));

		Console.WriteLine(CheckPhoneNumber("8 (905) 111-23-45"));
		Console.WriteLine(CheckPhoneNumber("8 (905) 11-23-45"));
		Console.WriteLine(CheckPhoneNumber("+7-905-121-23-45"));

		Console.WriteLine(FormatOnlyWordsWithOneSpace("Hello!!!   world---2025"));
	}

	public static string MaskingCard(string card)
	{
		return Regex.Replace(card, @"[^\d{4}](\d{4})", " ****");
	}

	public static int[] GetAllNumsInString(string input)
	{
		List<int> result = new List<int>();
		var matches = Regex.Matches(input, @"\d+");
		foreach (Match match in matches)
		{
			result.Add(int.Parse(match.Value));
		}
		return result.ToArray();
	}

	public static bool CheckPhoneNumber(string phoneNumber)
	{
		return Regex.IsMatch(phoneNumber,
			@"^(\+7-\d{3}-|8\s\(\d{3}\)\s)\d{3}-\d{2}-\d{2}$");
	}

	public static string FormatOnlyWordsWithOneSpace(string input)
	{
		StringBuilder sb = new StringBuilder();
		
		var matches = Regex.Matches(input, @"[a-zA-Zа-яА-Я]+");
		if (matches.Count == 0)
		{
			return string.Empty;
		}
		
		foreach (Match match in matches)
		{
			sb.Append($"{match.Value} ");
		}
		sb.Remove(sb.Length - 1, 1);
		
		return sb.ToString();
	}
}