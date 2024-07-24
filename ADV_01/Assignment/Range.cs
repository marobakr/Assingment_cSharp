namespace Assignment;

public class Range<T> where T : IComparable<T>
{
    private  T _min;
    private  T _max;

    public Range(T min, T max)
    {
        if (min.CompareTo(max) > 0)
        {
            return;
        }
        _min = min;
        _max = max;
    }

    public bool IsInRange(T value)
    {
        return value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0;
    }

    public T Length()
    {
        if (typeof(T) == typeof(int))
        {
            return (T)(object)(((int)(object)_max) - ((int)(object)_min));
        }
        else if (typeof(T) == typeof(double))
        {
            return (T)(object)(((double)(object)_max) - ((double)(object)_min));
        }
        else if (typeof(T) == typeof(decimal))
        {
            return (T)(object)(((decimal)(object)_max) - ((decimal)(object)_min));
        }
        else
            throw new InvalidOperationException("Unsupported type for length");
    }
}