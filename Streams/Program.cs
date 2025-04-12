using System.Text.Json;

namespace Streams;

class Program
{
    static void Main(string[] args)
    {
        FrequencyAnalysisOfTheText();
    }

    public static void FrequencyAnalysisOfTheText()
    {
        Dictionary<string, int> count = [];

        using var sr = new StreamReader(@"input.txt");
        string s;
        while (!sr.EndOfStream)
        {
            s = sr.ReadLine()!;
            foreach (var word in s.Split())
            {
                if (count.TryAdd(word, 1))
                {
                    continue;
                }
                count[word]++;
            }
        }
        
        using var sw = new StreamWriter(@"output.txt");
        foreach (var word in count.Keys.OrderByDescending(key => count[key]))
        {
            sw.WriteLine($"{word} : {count[word]}");
        }
    }

    public static void ReplaceOldToNew()
    {
        using var sr = new StreamReader(@"input.txt");
        using var result = new StreamWriter(@"textWithNew.txt");
        
        string s;
        while (!sr.EndOfStream)
        {
            s = sr.ReadLine()!;
            s = s.Replace("старое", "новое");
            result.WriteLine(s);
        }
    }
    
    public static bool ValidateJSON(string pathToFile)
    {
        string fileText = File.ReadAllText(pathToFile);

        try
        {
            Dictionary<string, object>? jsonData = JsonSerializer.Deserialize<Dictionary<string, object>>(fileText);
            if (jsonData == null)
            {
                return false;
            }
        }
        catch
        {
            return false;
        }
        return true;
    }
    
    public static void SaveEmployeesReportFromCsv(string inputPath)
    {
        if (Path.GetExtension(inputPath) != ".csv")
        {
            Console.WriteLine("Input file is not .csv");
            return;
        }

        List<Employee> employees = new List<Employee>();

        using var reader = new StreamReader(inputPath);

        reader.ReadLine(); // скипаем заголовки

        var line = reader.ReadLine();
        while (line != null)
        {
            if (string.IsNullOrEmpty(line))
            {
                continue;
            }

            var values = line.Split(',');
            employees.Add(new Employee
            {
                Name = values[1],
                Age = int.Parse(values[3]),
                Department = values[4],
            });

            line = reader.ReadLine();
        }

        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found");
            return;
        }

        var oldest = employees.OrderBy(e => e.Age).First();
        var averageByDept = employees.GroupBy(e => e.Department)
            .Select(g => new
                {
                    Department = g.Key,
                    Average = g.Average(e => e.Age)
                }
            ).ToList();

        using var writer = new StreamWriter("report.txt");
        var oldestMessage = $"Oldest employee: {oldest.Name}";
        writer.WriteLine(oldestMessage);
        Console.WriteLine(oldestMessage);
        foreach (var avgMessage in averageByDept.Select(department =>
                     $"Department: {department.Department} - Average age: {department.Average}"))
        {
            writer.WriteLine(avgMessage);
            Console.WriteLine(avgMessage);
        }
    }
}