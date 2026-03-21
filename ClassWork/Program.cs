using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;


namespace ClassWork;

class Program
{
	static void Main(string[] args)
	{
		string path = "input.txt";
		CreateTextFrequencyAnalyze(path);
		
		var employees = new List<Employee>
		{
			new Employee { Appointment = "Junior Developer", Experience = 1, Salary = 60000 },
			new Employee { Appointment = "Middle Developer", Experience = 3, Salary = 120000 },
			new Employee { Appointment = "Senior Developer", Experience = 6, Salary = 220000 },
			new Employee { Appointment = "Team Lead", Experience = 8, Salary = 280000 },
			new Employee { Appointment = "Project Manager", Experience = 10, Salary = 300000 },
			new Employee { Appointment = "QA Engineer", Experience = 2, Salary = 90000 },
			new Employee { Appointment = "DevOps Engineer", Experience = 5, Salary = 200000 },
			new Employee { Appointment = "System Analyst", Experience = 4, Salary = 150000 },
			new Employee { Appointment = "Architect", Experience = 12, Salary = 350000 },
			new Employee { Appointment = "Intern", Experience = 0, Salary = 30000 }
		};
		
		File.WriteAllText("output.json", JsonSerializer.Serialize(employees));
		
		SaveEmployeeDat(employees);
		var result =  LoadEmployeeDat("output.dat");

		Console.WriteLine(string.Join(" \n", result.Select(e => $"{e.Appointment};{e.Experience};{e.Salary}")));
		
		AnalyseWorkers("employees.csv");
	}


	public static void CreateTextFrequencyAnalyze(string filePath)
	{
		Dictionary<string, int>  wordsFrequency = new();

		using FileStream fileStream = new FileStream(filePath, FileMode.Open);
		using StreamReader streamReader = new StreamReader(fileStream);
		
		string? line;
		while ((line = streamReader.ReadLine()) != null)
		{
			line = Regex.Replace(line, @"[^a-zA-Zа-яА-Я0-9\s]", "");
			
			var words = line.ToLower().Split(' ');

			foreach (var word in words)
			{
				if (!wordsFrequency.TryAdd(word, 1))
				{
					wordsFrequency[word]++;
				}
			}
		}
		
		using StreamWriter streamWriter = new StreamWriter("output.txt");
		foreach (var word in wordsFrequency.OrderBy(w => w.Value))
		{
			streamWriter.WriteLine($"{word.Key} - {word.Value}");
		}
	}

	public static void SaveEmployeeDat(List<Employee> employees)
	{
		using FileStream fileStream = new FileStream("output.dat", FileMode.Create);
		using BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		foreach (Employee employee in employees)
		{
			binaryWriter.Write(employee.Appointment);
			binaryWriter.Write(employee.Experience);
			binaryWriter.Write(employee.Salary);
		}
	}

	public static List<Employee> LoadEmployeeDat(string filePath)
	{
		var result = new List<Employee>();
		
		using FileStream fileStream = new FileStream(filePath, FileMode.Open);
		using BinaryReader binaryReader = new BinaryReader(fileStream);
		while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
		{
			var employee = new Employee
			{
				Appointment = binaryReader.ReadString(),
				Experience = binaryReader.ReadInt32(),
				Salary = binaryReader.ReadDecimal(),
			};
			result.Add(employee);
		}
		
		return result;
	}

	public static void AnalyseWorkers(string filePath)
	{
		var workers = new List<Worker>();
		using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
		{
			using StreamReader streamReader = new StreamReader(fileStream);
			var line = streamReader.ReadLine(); //ignoring headers
			while ((line = streamReader.ReadLine()) != null)
			{
				var data = line.Split(',');
				var worker = new Worker
				{
					Name = data[0],
					Age = int.Parse(data[1]),
					Department = data[2]
				};
				workers.Add(worker);
			}
		}

		var oldest = workers.MaxBy(w => w.Age);
		
		var departmentsGroups = workers.GroupBy(w => w.Department)
			.ToDictionary(group => group.Key, 
				group => group.Average(w => w.Age));

		using StreamWriter streamWriter = new StreamWriter("outputWorkers.txt");

		streamWriter.WriteLine($"Самый старший сотрудник: {oldest!.Name}. Возраст: {oldest.Age}");
		foreach (var departmentsGroup in departmentsGroups)
		{
			streamWriter.WriteLine($"{departmentsGroup.Key}: средний возраст: {departmentsGroup.Value}");
		}
		
	}
}


