// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using ParallelTasks;
using ParallelTasks.ExamsTask;
using ParallelTasks.Singleton;

/*
var eratosfenTask = new EratosfenTask(100);

eratosfenTask.CountPrimeNumbers();

Console.WriteLine(eratosfenTask.PrimeNumbersCount);

Console.WriteLine(string.Join(" ", eratosfenTask.AllPrimeNumbers));


Theatre theatre = new Theatre();
theatre.StartAct();
*/
/*
var computer = new Computer("Windows");


Parallel.For(0, 5, i =>
{
    computer.LaunchOs(i.ToString());
});
*/

//Садовники
/*
void First(char[,] garden)
{
    bool right = true;
    var rows = garden.GetLength(0);
    var columns = garden.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        if (right)
        {
            for (int j = 0; j < columns; j++)
            {
                if (char.IsLetter(garden[i, j]))
                {
                    columns = j;
                    break;
                }

                garden[i, j] = 'a';
                Thread.Sleep(1);
            }
        }
        else
        {
            for (int j = columns - 1; j >= 0; j--)
            {
                if (char.IsLetter(garden[i, j]))
                {
                    columns--;
                    continue;
                }
                garden[i, j] = 'a';
                Thread.Sleep(1);
            }
        }
        right = !right;
    }
}

void Second(char[,] garden)
{
    bool up = true;
    var rows = garden.GetLength(0);
    var columns = garden.GetLength(1);
    var upperBound = 0;
    for (int i = columns - 1; i >=0 ; i--)
    {
        if (up)
        {
            for (int j = rows - 1; j >= upperBound; j--)
            {
                if (char.IsLetter(garden[j, i]))
                {
                    upperBound = j;
                    break;
                }

                garden[j, i] = 'b';
                Thread.Sleep(1);
            }
        }
        else
        {
            for (int j = upperBound; j < rows; j++)
            {
                if (char.IsLetter(garden[j, i]))
                {
                    upperBound = j;
                    continue;
                }

                garden[j, i] = 'b';
                Thread.Sleep(1);
            }
        }
        up = !up;
    }
}


var arr = new char[10, 10];

void FirstGardenerThread() => First(arr);
void SecondGardenerThread() => Second(arr);


Thread firstGardener = new Thread(FirstGardenerThread);
Thread secondGardener = new Thread(SecondGardenerThread);

firstGardener.Start();
secondGardener.Start();

firstGardener.Join();
secondGardener.Join();


for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(arr[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
*/

//Параллелизм векторов
/*
var vectors = new List<Vector>();
var random = new Random();
for (int i = 0; i < 300_000; i++)
{
    vectors.Add(new Vector
    {
        X = random.Next(-100, 100),
        Y = random.Next(-100, 100),
        Z = random.Next(-100, 100)
    });
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(vectors[i]);
}

int k = random.Next(3100);
Console.WriteLine($"Коэффициэнт: {k}");
int value = 2;
int numberOfThreads = 1;


var countDownEvent = new CountdownEvent(numberOfThreads);
var stopWatch = new Stopwatch();

stopWatch.Start();

for (int indexOfThread = 0; indexOfThread < numberOfThreads; indexOfThread++)
{
    int index2 = indexOfThread;
    ThreadPool.QueueUserWorkItem(_ =>
    {
        try
        {
            ProcessCircle(vectors, k, index2, numberOfThreads);
        }
        finally
        {
            countDownEvent.Signal();
        }
    });
}

countDownEvent.Wait();
stopWatch.Stop();

Console.WriteLine($"Миллисекунды: {stopWatch.ElapsedMilliseconds}");



for (int i = 0; i < 10; i++)
{
    Console.WriteLine(vectors[i]);
}

void ProcessFirstHalf(List<Vector> vectors, int k)
{
    for (int i = 0; i < vectors.Count / 2; i++)
    {
        vectors[i].X *= k;
        vectors[i].Y *= k;
        vectors[i].Z *= k;
    }
}

void ProcessSecondHalf(List<Vector> vectors, int k)
{
    for (int i = vectors.Count / 2; i < vectors.Count; i++)
    {
        vectors[i].X *= k;
        vectors[i].Y *= k;
        vectors[i].Z *= k;
    }
}

void ProcessCircle(List<Vector> vectors, int k, int numberOfThread, int countOfThreads)
{
    for (int i = numberOfThread; i < vectors.Count ; i += countOfThreads)
    {
        vectors[i].X *= k;
        vectors[i].Y *= k;
        vectors[i].Z *= k;
    }
}


var listActions = new List<Action>();

for (int i = 0; i < 10; i++)
{
    var iCopy = i;
    listActions.Add(() => Console.WriteLine($"{iCopy}"));
}

foreach (var action in listActions)
{
    action();
}
*/

//Простые числа
/*
static bool IsPrimary(int num)
{
    for (int index = 2; index < num; index++)
    {
        if (num % index == 0)
        {
            return false;
        }
    }
    return true;
}


static void CountOfPrimaryNums(int numsCount)
{
    SortedList<int, int> countSortedList = new SortedList<int, int>();
    countSortedList.Add(2, 2);
        
    object locker = new object();
        
    Parallel.For(3, numsCount,new ParallelOptions
    {
        MaxDegreeOfParallelism = Environment.ProcessorCount
    }, i =>
    {
        if (IsPrimary(i))
        {
            lock (locker)
            {
                countSortedList.Add(i, i);
            }
        }
    });
    File.AppendAllText("output.txt", string.Join(", ", 
        countSortedList.Values) + Environment.NewLine);
        
    Console.WriteLine(countSortedList.Count);
}
*/


//Сдача экзаменов
/*
var math = new Subject("Математика", new Teacher("Иванов"));
var physics = new Subject("Физика", new Teacher("Петров"));
var cs = new Subject("Информатика", new Teacher("Сидоров"));

var subjects = new List<Subject> { math, physics, cs };
var students = Enumerable.Range(1, 10)
    .Select(id => new Student(id)).ToList();

var stopwatch = new Stopwatch();

stopwatch.Start();
Parallel.ForEach(students, student =>
{
    Parallel.ForEach(subjects, subject =>
    {
        student.PrepareForSubject(subject);
        student.TakeExam(subject);
    });
});
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed.Seconds);

students.ForEach(student => student.ExamStatuses.Clear());

stopwatch.Reset();

stopwatch.Start();
Parallel.ForEach(students, student =>
{
    foreach (var subject in subjects)
    {
        student.PrepareForSubject(subject);
        student.TakeExam(subject);
    }
});
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed.Seconds);
*/


int num = 0; 
// устанавливаем метод обратного вызова
TimerCallback tm = new TimerCallback(Count);
// создаем таймер
Timer timer = new Timer(tm, num, 0, 2000);

Console.ReadLine();

static void Count(object obj)
{
    int x = (int)obj;
    for (int i = 1; i < 9; i++, x++)
    {
        Console.WriteLine($"{x * i}");      
    }
}