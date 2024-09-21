namespace Assignment;

public class Duration
{
    /* Required Constructors */
    public Duration()
    {
        
    }
    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Duration(int totalSeconds)
    {
        Hours = totalSeconds / 3600;
        Minutes = (totalSeconds % 3600) / 60;
        Seconds = totalSeconds % 60;
    }

    public Duration(int totalMinutes, int seconds)
    {
        Hours = totalMinutes / 60;
        Minutes = totalMinutes % 60;
        Seconds = seconds;
    }

    public int Hours { get; }
    public int Minutes { get; }
    public int Seconds { get; }

    
    
    /* Override */
    public override string ToString()
    {
        return $"Hours: {Hours}, Minutes: {Minutes}, Seconds:{Seconds}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Duration otherPerson)
        {
            return Hours == otherPerson.Hours && Minutes == otherPerson.Minutes;
        }
        return false;
    }

    public override int GetHashCode()
    {
        // Use a combination of fields' hash codes
        return HashCode.Combine(Hours, Minutes,Seconds);
    }
    
}