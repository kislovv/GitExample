using Timer = System.Timers.Timer;

namespace ParallelTasks;

public class Theatre
{
    private List<int> viewers = Enumerable.Range(1, 100).ToList();
    private int timeOfAct = 20;
    private int countOfWC = 5;

    public void StartAct()
    {
        SemaphoreSlim wc = new SemaphoreSlim(5, 5);
        Task task = Task.Run(() =>
        {
            for (int i = 0; i < timeOfAct; i++)
            {
                ShowAct(i + 1);
            }
            
            Console.WriteLine("Представление окончено!");
        });

        Parallel.ForEach(viewers, i =>
        {
            var timeToGoWC = new Random().Next(1, 20);
            using Timer timer = new Timer(timeToGoWC * 1000);
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