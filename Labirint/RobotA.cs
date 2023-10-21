namespace Labirint;

public class RobotA : IRobot
{
    public (int x, int y) CurrentPosition { get; set; }
    public Side Side { get; set; }
    public void Move()
    {
        CurrentPosition = Side switch
        {
            Side.Up => (CurrentPosition.x - 1, CurrentPosition.y),
            Side.Left => (CurrentPosition.x, CurrentPosition.y - 1),
            Side.Right => (CurrentPosition.x, CurrentPosition.y + 1),
            Side.Down => (CurrentPosition.x + 1, CurrentPosition.y),
            _ => CurrentPosition
        };
    }

    public void Turn(Side side)
    {
        Side = side;
    }
}