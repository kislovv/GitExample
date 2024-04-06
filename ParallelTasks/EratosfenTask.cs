namespace ParallelTasks;

public class EratosfenTask(int n)
{
    public int N { get; set; } = n;
    public int PrimeNumbersCount { get; set; } = 0;
    public List<int> BasePrimeNumbers { get; set; } = [];
    public List<int> AllPrimeNumbers { get; set; } = [];

    public void CountPrimeNumbers()
    {
        object _lock = new();
        switch (N)
        {
            case 0:
                return;
            case < 3:
                PrimeNumbersCount = N;
                return;
        }

        PrimeNumbersCount = 2;
        BasePrimeNumbers.AddRange([2,3]);
        
        var lastCheckedPrimaryNum = (int) Math.Ceiling(Math.Sqrt(N));
        var primeNumbersCount = PrimeNumbersCount;
        for (var i = 4; i < lastCheckedPrimaryNum; i++)
        {
            if (CheckPrimaryNum(i))
            {
                BasePrimeNumbers.Add(i);
                primeNumbersCount++;
            }
        }
        
        AllPrimeNumbers.AddRange(BasePrimeNumbers);
        
        Parallel.For(lastCheckedPrimaryNum, N + 1, i =>
        {
            if (CheckPrimaryNum(i))
            {
                try
                {
                    Monitor.Enter(_lock);
                    AllPrimeNumbers.Add(i);
                    
                    Monitor.Pulse(_lock);
                    
                    Console.WriteLine($"Added {i}");
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
                Interlocked.Add(ref primeNumbersCount, 1);
            }
        });
        PrimeNumbersCount = primeNumbersCount;
        AllPrimeNumbers.Sort();
    }

    private bool CheckPrimaryNum(int num)
    {
        return BasePrimeNumbers.All(b => num % b != 0);
    }
}