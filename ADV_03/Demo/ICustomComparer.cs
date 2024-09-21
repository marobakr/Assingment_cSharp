namespace session_3;

/* Use strategy design pattern*/
public interface ICustomComparer
{
    bool Compare(int x, int y);
}

internal class AscComparer : ICustomComparer
{
    // public bool Compare(int x, int y)
    // {
    //     return x > y;
    // }

    /* Syntax Sugar*/
    public bool Compare(int x, int y) => x > y;
}

internal class DescComparer : ICustomComparer
{
    
    public bool Compare(int x, int y) => x < y;
}

