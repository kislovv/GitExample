using Labirint;

var playGround = new RobotsPlayground()
{
    FinishPosition = (5, 5),
    StartPosition = (0, 0),
    Labirint = new bool[6, 6]
};

var isSolve = playGround.LabirintIsSolve(new RobotA(), out var time);
if (isSolve)
{
    Console.WriteLine(time);
}
else
{
    Console.WriteLine("Лабиринт не пройден!");
}

