using Timer = System.Timers.Timer;

namespace ParallelTasks;

public class Theatre
{
    private readonly List<int> _viewers = Enumerable.Range(1, 100).ToList();
    private const int TimeOfAct = 20;

    public void StartAct()
    {
        SemaphoreSlim wc = new SemaphoreSlim(5, 5);
        Task task = Task.Run(() =>
        {
            for (int i = 0; i < TimeOfAct; i++)
            {
                ShowAct(i + 1);
            }
            
            Console.WriteLine("Представление окончено!");
        });

        Parallel.ForEach(_viewers, i =>
        {
            var timeToGoWc = new Random().Next(1, 20); 
            Timer timer = new Timer(timeToGoWc * 1000);
            timer.AutoReset = false;
            timer.Elapsed += (_, _) =>
            {
                if (wc.CurrentCount == 0)
                    Console.WriteLine($"Все места заняты. " +
                                      $"Гость № {i} ожидает.");
                wc.Wait();
                Console.WriteLine($"Гость № {i} занял свободное место.");
                Task.Delay(new Random().Next(1, 3) * 1000).Wait();
                Console.WriteLine($"Гость № {i} освободил место.");
                wc.Release();
            };
            timer.Start();
        });
        
        task.Wait();
    }

    private void ShowAct(int iterations)
    {
        var delay = Task.Delay(1000);
        delay.Wait();
        Console.WriteLine($"Прошла {iterations} секунда спектакля!");
    }
}