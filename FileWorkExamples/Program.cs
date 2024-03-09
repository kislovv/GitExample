using System.Text;
using System.Text.Json;
using FileWorkExamples;

var journal = new Journal()
{
    Marks = new List<Mark>()
    {
        new Mark()
        {
            Date = DateTimeOffset.Now.Date,
            Score = 5,
            StudentFullName = "Sidorov.V.A"
        },
        new Mark()
        {
            Date = DateTimeOffset.Now.Date,
            Score = 4,
            StudentFullName = "Petrov.M.V"
        },
        new Mark()
        {
            Date = DateTimeOffset.Now.Date,
            Score = 5,
            StudentFullName = "Kartoshkina.A.D"
        },
        new Mark()
        {
            Date = DateTimeOffset.Now.Date,
            Score = 2,
            StudentFullName = "Vladislav.M.D"
        },
    }
};

var jsonJournal = JsonSerializer.Serialize(journal);
//File.WriteAllText("journal.json", jsonJournal);

using (var fileStream = new FileStream("journal.json", FileMode.OpenOrCreate))
{
    fileStream.Write(Encoding.UTF8.GetBytes(jsonJournal));
    fileStream.Flush();
}

Thread.Sleep(5000);


using (var fileStream = new FileStream("journal.json", FileMode.OpenOrCreate))
{

    using var streamReader = new StreamReader(fileStream);

    var file = streamReader.ReadToEnd();

    journal = JsonSerializer.Deserialize<Journal>(file);

    var newMarks = new List<Mark>();
    journal!.Marks.ForEach(m =>
    {
        newMarks.Add(new Mark
        {
            Date = DateTimeOffset.Now.AddDays(1).Date,
            Score = 2,
            StudentFullName = m.StudentFullName
        });
    });
    
    journal.Marks.AddRange(newMarks);

    using var streamWriter = new StreamWriter(fileStream);
    
    streamWriter.Write(JsonSerializer.Serialize(journal));
}

Console.WriteLine("Work with file ended!");