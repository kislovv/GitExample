using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ClassWork;

public class Cinema
{
    private List<int> _viewers = Enumerable.Range(1,300).ToList();
    private readonly CancellationTokenSource _cts = new CancellationTokenSource();
    private SemaphoreSlim _wc = new SemaphoreSlim(5,5);

    public void StartSession()
    {
        Task session = Task.Run(() =>
        {
            for (int i = 1; i <= 20; i++)
            {
                Task.Delay(1000).Wait();
                Console.WriteLine($"Прошло {i} секунд фильма");
            }
        });

        Parallel.ForEach(_viewers, viewer =>
        {
            var timeToGoToWc = Random.Shared.Next(1, 20);
            Task.Delay(timeToGoToWc * 1000).Wait();
            if (_wc.CurrentCount == 0)
            {
                Console.WriteLine($"viewer with number {viewer} is waiting");
            }

            _wc.Wait();
            Console.WriteLine($"viewer with number {viewer} go to wc");
            Task.Delay(1000 * Random.Shared.Next(1,3)).Wait();
            _wc.Release();
            Console.WriteLine($"viewer with number {viewer} go to cinema");
        });
        
        session.Wait();
    }
}