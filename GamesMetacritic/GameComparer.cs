namespace GamesMetacritic;

public class GameComparer: IComparer<Game>
{
    public int Compare(Game? y, Game? x)
    {
        if (x == null && y == null)
            return 0;
        if (x == null)
            return -1;
        if (y == null)
            return 1;

        int sumX = x.GetSumOfCriteries();
        int sumY = y.GetSumOfCriteries();
        
        return sumX > sumY ? 1 
            : sumX < sumY ? -1 
            : 0;
    }
}