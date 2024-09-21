namespace session_4.FiFA;
/* 01 Subscriber */
public class Player
{
    public string Name { get; set; }
    public string Team { get; set; }

    public void Run(object sender, EventArgs e )
    {
        Ball ball = (Ball) sender;
        Console.WriteLine($"{this} is running... {ball.Location} id:{ball.Id}");
    }
    public override string ToString() => $"Player: Name={Name}, Team={Team}";
    
}