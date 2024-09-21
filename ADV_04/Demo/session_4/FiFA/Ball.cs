namespace session_4.FiFA;

/* Publisher */
public class Ball
{
    public int Id { get; set; }

    /* Event Based on Action */
    // public  Action<Location> ? LocationChanged;
    
    /* Event Handler [Special Delegate]*/
    
    // Non Generic Delegate
    public EventHandler? LocationChanged; /* Represents the method that will handle an event that has no event data. */

    
    private Location location;
    public Location Location
    {
        get => location;
        set
        {
            if (! value.Equals( location) )
            {
                /*
                 * EventArgs.Empty is a static field that provides an empty value for the event data.
                 */
                /*
                 * this is the object that is currently executing the method
                 */
                location = value  ;
                LocationChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
    
    public override string ToString()
    {
        return $"Ball: Id={Id}, Location=({Location})";
    }
}