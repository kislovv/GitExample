namespace MusicAwards;

public class Music
{
    public Music(string name, string artist, double score, long numberListenings)
    {
        SongName = name;
        Artist = artist;
        Score = score;
        NumberListenings = numberListenings;
    }
    public string SongName { get; set; }
    public string Artist { get; set; }
    public double Score { get; set; }
    public long NumberListenings { get; set; }

    public override string ToString()
    {
        return $"{SongName} - {Artist} - {Score} - {NumberListenings}";
    }

    public override bool Equals(object? obj)
    {
        return this.GetHashCode() == obj.GetHashCode();
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(SongName, Artist, Score, NumberListenings);
    }
}