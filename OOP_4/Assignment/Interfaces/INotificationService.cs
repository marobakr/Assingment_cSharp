namespace Assignment.Interfaces;

public interface INotificationService
{
    public void SendNotification(string recipient , string msg);
}