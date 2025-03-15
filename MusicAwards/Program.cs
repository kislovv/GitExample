namespace MusicAwards;

class Program
{
    static void Main(string[] args)
    {
        List<Music> musics = new List<Music>();
        musics.Add(new Music("Summertime Sadness", "Lana Del Ray", 8.3, 1798980658));
        musics.Add(new Music("Summertime Sadness", "Lana Del Ray", 8.3, 1798980658));
        musics.Add(new Music("Туган Як", "Василя Фаттахова", 9.8, 333679));
        musics.Add(new Music("Текила - любовь", "Валерий Меладзе", 9.4 , 2843406));
        musics.Add(new Music("Black Hole Sun", "Soundgarden", 8.5 , 799737421));
        musics.Add(new Music("Романс", "Диктофон", 6.9 , 313246));
        musics.Add(new Music("Полина", "Noggano", 7.2 , 1961522));
        
        
        //musics.Sort(new MusicComparator());
        //musics.Reverse();
        
        foreach (Music music in musics)
            Console.WriteLine(music);

        Console.WriteLine(musics[0].Equals(musics[1]));
        
        
    }
}