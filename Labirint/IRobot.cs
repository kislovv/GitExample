namespace Labirint;

public interface IRobot
{
    (int x, int y) CurrentPosition { get; set; }
    Side Side { get; set; }
    void Move();
    void Turn(Side side);
}