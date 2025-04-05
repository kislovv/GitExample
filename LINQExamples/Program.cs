using LINQExamples;

Console.WriteLine(string.Join(", ",ProcedureTasks.FindAllDisappearedNums([1,2,4,4,5,5,7,8,9,10,10])));

string[] array = ProcedureTasks.GetFizzBuzz(Enumerable.Range(10, 30).ToArray());
foreach (string numOfFizzBuzz in array)
{
    Console.WriteLine(numOfFizzBuzz);
}

string record = "LLAPPPAPP";
Console.WriteLine(ProcedureTasks.CheckRecord(record));


var arr = new List<int>{1,2,3,4,5,6,7,8,9,10,11};
Console.WriteLine(arr.Where(num => num % 2 != 0)
    .Select(num => num.ToString())
    .Aggregate(
        "Numbers: " ,
        (a, b) => a + "," + b, 
        result => result + " |Done!"));

int count = ProcedureTasks.UniqueMorseRepresentations(["cat", "card", "fact", "road", "return", "gin", "zen"]);
Console.WriteLine(count);

Console.WriteLine(string.Join(", ", ProcedureTasks.FindWords(["qwerytryity", "dfgdsfg", "vevrevr onnoi"])));

Console.WriteLine(ProcedureTasks.GetMajorityElement([1, 2, 3]));
Console.WriteLine(ProcedureTasks.IsSubsequence("abcdf", "bd"));
Console.WriteLine(ProcedureTasks.IsSubsequence("abcdf", "db"));



