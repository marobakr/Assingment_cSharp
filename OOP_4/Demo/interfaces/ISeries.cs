namespace Demo.interfaces;

public interface ISeries
{
    // Public By default
    int Current { get; set; }
    void GetNext();
    void Rest();

}

public class SeriesByTwo : ISeries
{
    private int current;
    public int Current
    {
        get
        {
            return current;
        }
        set
        {
            current = value;
        }
    }

    public void GetNext()
    {
        current += 2;
    }

    public void Rest()
    {
        current = 0;
    }
}
 
public class SeriesByThere : ISeries
{
    private int current;
    public int Current
    {
        get
        {
            return current;
        }
        set
        {
            current = value;
        }
    }

    public void GetNext()
    {
        current += 3;
    }

    public void Rest()
    {
        current = 0;
    }
}