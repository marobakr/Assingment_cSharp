namespace session_1;

public class Point
{
    public int X { get; set; }
    public int y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"({X},{y})";
    }
}