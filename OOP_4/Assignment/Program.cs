using Assignment.Interfaces;

namespace Assignment;

/* ================ Part 02 Implement Class ================*/

#region Question 01

public class Circle : ICircle
{
    public double Radius { get; set; }

    public double Area => Math.PI * Radius * Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Circle with radius: {Radius}, Area: {Area}");
    }
}

public class Rectangle : IRectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area => Width * Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Rectangle with width: {Width}, height: {Height}, Area: {Area}");
    }
}


#endregion

#region Question 02

public class BasicAuthenticationService :IAuthenticationService
{
    private const string ValidUsername = "user1";
    private const string ValidPassword = "password1";
    private const string UserRole = "Admin";
    
    public bool AuthenticateUser(string username, string password)
    {
        return username == ValidUsername && password == ValidPassword;
    }

    public bool AuthorizeUser(string username, string role)
    {
        return username == ValidUsername && role == UserRole;
    }
}

#endregion

#region Question 03

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string recipient, string msg)
    {
        Console.WriteLine($"the email recipient is {recipient} , and the msg is {msg}");
    }
}
public class SmsNotificationService : INotificationService
{
    public void SendNotification(string recipient, string msg)
    {
        Console.WriteLine($"Sending SMS to {recipient} with message: {msg}");
    }
}
public class PushNotificationService : INotificationService
{
    public void SendNotification(string recipient, string msg)
    {
        Console.WriteLine($"Sending push notification to {recipient} with message: {msg}");
    }
}
#endregion

class Program 
{
    static void Main(string[] args)
    {

        /* ================ Part 01 ================*/
        
        #region Questions Chosen
          /*
           * 1: (b)
           * 2: (a)
           * 3: (b)
           * 4: (b)
           * 5: (d) implements keyword is not used. Instead,  uses the :
           * 6: (b) 
           * 7: (b)
           * 8: (b) 
           * 9: (b) 
           * 10: (c)
           */
        #endregion
        
        /* ================ Part 02 Create an Instance From Class ================*/

        #region Question 01:
        /*ICircle Circle = new Circle(3);
        Circle.DisplayShapeInfo();
        IRectangle rectangle = new Rectangle(4, 7);
        rectangle.DisplayShapeInfo();*/
        #endregion

        #region Question 02:

        /*BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService();
       bool isAuthenticated = basicAuthenticationService.AuthenticateUser("marwan", "10200");
       Console.WriteLine(isAuthenticated);

       bool isAuthorized = basicAuthenticationService.AuthorizeUser("user1", "Admin");
       Console.WriteLine($"user1 authorized for Admin: {isAuthorized}");*/
       



        #endregion

        #region Question 03
        string recipient = "marobakr@.com";
        string msg = "Hello, World.";
        
        EmailNotificationService emailNotificationService = new EmailNotificationService();
        SmsNotificationService smsNotificationService = new SmsNotificationService();
        PushNotificationService pushNotificationService = new PushNotificationService();

        emailNotificationService.SendNotification(recipient,msg);
        smsNotificationService.SendNotification(recipient,msg);
        pushNotificationService.SendNotification(recipient,msg);

        #endregion

    }
}