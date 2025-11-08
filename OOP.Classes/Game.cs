namespace OOP.Classes;

public class Game
{
    private int _scoreCount = 0;
    private double _totalScore = 0;
    private readonly double _coefficient;
    
    public required string Name { get; init; }
    public Genre Genre { get; }
    public double Rating { get; private set; }
    
    
    public Game(Genre genre)
    {
        Genre = genre;
        _coefficient = new Random().NextDouble() * 10;
    }

    public void AddScore(int score)
    {
        if (score > 10 || score < 0)
        {
            throw new ArgumentException("Score must be between 0 and 10");
        }
        _scoreCount++;
        _totalScore += score * _coefficient;
        Rating = Math.Round(_totalScore / _scoreCount, 2);
    }
}