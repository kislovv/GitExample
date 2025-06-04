namespace HeroBuilderExample;

class Program
{
    static void Main(string[] args)
    {
        var heroBuilder = new HeroBuilder("Bob");
        heroBuilder.WithPower(3);
        heroBuilder.WithIntelligence(4);
        heroBuilder.WithAgility(3);
        var hero = heroBuilder.Build();
        
        var heroAlice = new HeroBuilder("Alice")
            .WithPower(2)
            .WithAgility(5)
            .WithIntelligence(3)
            .Build();
        
        Console.WriteLine(hero);
        Console.WriteLine(heroAlice);
        
    }
}