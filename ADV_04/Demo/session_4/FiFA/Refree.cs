namespace session_4.FiFA;
/* 02 Subscriber */
public class Refree
{
    public string Name { get; set; }

    public void Look(object sender, EventArgs e )
    {
        Ball ball = (Ball) sender;
        Console.WriteLine($"{this} is looking... {ball.Location} for id:{{ball.Id}}");
    }
    public override string ToString() => $"Referee: Name={Name} {this}";
}