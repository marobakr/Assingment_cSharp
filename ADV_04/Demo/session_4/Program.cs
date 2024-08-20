using session_4.FiFA;

namespace session_4;
class Program
{
    static void Main(string[] args)
    {

        Ball ball = new Ball()
        {
            Id = 10,
        };
        
         Player p1 = new Player() { Name = "maro", Team = "Barcelona" ,};
         Player p2 = new Player() { Name = "leo", Team = "PSG" };
         Player p3 = new Player() { Name = "cristiano", Team = "Al Nassr" };
         Player p4 = new Player() { Name = "neymar", Team = "Al Hilal" };
    
         Refree referee = new Refree() { Name = "John Doe" };

         /* Subscript [Register] */
         ball.LocationChanged += p1.Run;
         ball.LocationChanged += p2.Run;
         ball.LocationChanged += p3.Run;
         ball.LocationChanged += p4.Run;
         ball.LocationChanged += referee.Look;
         
         /* UnSubscript  */
         ball.LocationChanged -= p3.Run;

         Console.WriteLine("Ball Location has been changed...");
         ball.Location = new Location()
         {
                X = 10,
                Y = 20,
                Z = 30
            };
         Console.WriteLine("End the game...");

    }
}
