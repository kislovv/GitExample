using System.Collections;

namespace MusicAwards;

public class MusicComparator : IComparer<Music>
{
    public int Compare(Music? music1, Music? music2)
    {
        double listenCoeff = music1.NumberListenings / (double)music2.NumberListenings;
        double balancedScore = listenCoeff * music1.Score;
        
        return balancedScore.CompareTo(music2.Score);
    }
}