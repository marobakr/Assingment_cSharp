namespace Session_4.Oprator_Overloading;

/* Model: this class is a class that represents a table in Database*/
public class User
{
    public int  Id { get; set; }
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string SecuritySteamp { get; set; }

    public static /*UserViewModel*/ explicit operator UserViewModel(User user)
    {
        string[] names = user.Fullname.Split(" ") ;
        return new UserViewModel()
        {
            Id = user.Id,
            Email = user.Email,
            Fname = names[0],
            Lname = names[1],
        };
    }
}