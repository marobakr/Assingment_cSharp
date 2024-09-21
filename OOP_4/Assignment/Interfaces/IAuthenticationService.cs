namespace Assignment.Interfaces;

public interface IAuthenticationService
{
    bool AuthenticateUser(string username, string password);
    bool AuthorizeUser(string username, string role);
}