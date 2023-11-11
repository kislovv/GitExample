using System.Diagnostics;

namespace Labirint;

public class RobotsPlayground
{
    public bool[,] Labirint { get; init; }
    public (int x, int y) StartPosition { get; init; }
    public (int x, int y) FinishPosition { get; init; }
    public bool LabirintIsSolve(IRobot robot, out long time)
    {
        var sw = Stopwatch.StartNew();
        while (!robot.CurrentPosition.Equals(FinishPosition))
        {
            var startedSide = robot.Side;
            var wasTurn = false;
            switch (robot.Side)
            {
                case Side.Down:
                {
                    if (CheckPoint(Labirint,
                            (x: robot.CurrentPosition.x,
                                y: robot.CurrentPosition.y + 1)))
                    {
                        robot.Move();
                        robot.CurrentPosition = (robot.CurrentPosition.x,
                            robot.CurrentPosition.y + 1);
                        wasTurn = false;
                    }
                    else
                    {
                        robot.Turn(Side.Left);
                        wasTurn = true;
                    }
                    break;
                }
                case Side.Up:
                    if (CheckPoint(Labirint,
                            (x: robot.CurrentPosition.x,
                                y: robot.CurrentPosition.y -1)))
                    {
                        robot.Move();
                        robot.CurrentPosition = (robot.CurrentPosition.x,
                            robot.CurrentPosition.y - 1);
                        startedSide = Side.Up;
                    }
                    else
                    {
                        robot.Turn(Side.Right);
                        wasTurn = true;
                    }
                    break;
                case Side.Left:
                    if (CheckPoint(Labirint,
                            (x: robot.CurrentPosition.x,
                                y: robot.CurrentPosition.y + 1)))
                    {
                        robot.Move();
                        robot.CurrentPosition = (robot.CurrentPosition.x,
                            robot.CurrentPosition.y + 1);
                        startedSide = Side.Left;
                    }
                    else
                    {
                        robot.Turn(Side.Up);
                        wasTurn = true;
                        
                    }
                    break;
                case Side.Right:
                    if (CheckPoint(Labirint,
                            (x: robot.CurrentPosition.x,
                                y: robot.CurrentPosition.y + 1)))
                    {
                        robot.Move();
                        robot.CurrentPosition = (robot.CurrentPosition.x,
                            robot.CurrentPosition.y + 1);
                    }
                    else
                    {
                        robot.Turn(Side.Left);
                        startedSide = Side.Left;
                    }
                    break;
            }
        }


        sw.Stop();
        time = sw.ElapsedMilliseconds;
        return true;
    }

    private bool CheckPoint(bool[,] labirint, (int x, int y) step)
    {
        if (labirint.GetLength(0) - 1 > step.x ||
            labirint.GetLength(1) - 1 > step.y)
        {
            return false;
        }

        return labirint[step.x, step.y];
    }
}