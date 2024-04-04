namespace ParallelTasks;

public class EratosfenTask(int n)
{
    public int N { get; set; } = n;
    public int PrimeNumbersCount { get; set; } = 0;
    public List<int> BasePrimeNumbers { get; set; } = [];

    public void CountPrimeNumbers()
    {
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
        
        Parallel.For(lastCheckedPrimaryNum, N + 1, i =>
        {
            if (CheckPrimaryNum(i))
            {
                Interlocked.Add(ref primeNumbersCount, 1);
            }
        });
        PrimeNumbersCount = primeNumbersCount;
    }

    private bool CheckPrimaryNum(int num)
    {
        return BasePrimeNumbers.All(b => num % b != 0);
    }
}