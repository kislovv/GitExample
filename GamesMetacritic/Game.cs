using System.Security.Cryptography.X509Certificates;

namespace GamesMetacritic;

public class Game
{
    public string Name { get; init; }
    private Dictionary<Critery, byte> _criteries { get; } = new();

    public void SetScore(Critery critery, byte score)
    {
        _criteries[critery] = score;
    }

    public int GetSumOfCriteries()
    {
        int sum = 0;
        foreach (var score in _criteries.Values)
        {
            sum += score;
        }

        return sum;
    }
    public Genre Genre { get; init; }
}