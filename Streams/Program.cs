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
}