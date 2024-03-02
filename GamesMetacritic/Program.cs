using GamesMetacritic;

var dota2 = new Game
{
    Name = "Dota2",
    Genre = Genre.Moba,
};
dota2.SetScore(Critery.Story, 1);
dota2.SetScore(Critery.Music, 100);
dota2.SetScore(Critery.Optimisation, 100);
dota2.SetScore(Critery.Graphics, 80);
dota2.SetScore(Critery.OpenWorld, 1);
dota2.SetScore(Critery.Characters, 100);

var cs2 = new Game
{
    Name = "CS2",
    Genre = Genre.Shooter,
};
cs2.SetScore(Critery.Story, 1);
cs2.SetScore(Critery.Music, 80);
cs2.SetScore(Critery.Optimisation, 60);
cs2.SetScore(Critery.Graphics, 80);
cs2.SetScore(Critery.OpenWorld, 1);
cs2.SetScore(Critery.Characters, 50);

var minecraft = new Game
{
    Name = "Minecraft",
    Genre = Genre.BattleRoyale,
};

minecraft.SetScore(Critery.Story, 99);
minecraft.SetScore(Critery.Music, 100);
minecraft.SetScore(Critery.Optimisation, 50);
minecraft.SetScore(Critery.Graphics, 100);
minecraft.SetScore(Critery.OpenWorld, 100);
minecraft.SetScore(Critery.Characters, 100);

var hsr = new Game
{
    Name = "HSR",
    Genre = Genre.Strategy
};

hsr.SetScore(Critery.Story, 100);
hsr.SetScore(Critery.Music, 50);
hsr.SetScore(Critery.Optimisation, 80);
hsr.SetScore(Critery.Graphics, 70);
hsr.SetScore(Critery.OpenWorld, 1);
hsr.SetScore(Critery.Characters, 100);
var games = new List<Game>
{
    dota2, cs2, minecraft, hsr
};

Console.WriteLine(string.Join(",\n\r", games.Select(g => g.Name)));

games.Sort(new GameComparer());
Console.WriteLine("\n\r");

Console.WriteLine(string.Join(",\n\r", games.Select(g => g.Name)));