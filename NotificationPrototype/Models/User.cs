namespace NotificationPrototype.Models;

public class User
{
    public List<NotificationType> NotificationPreferences { get; set; }
    public string Email { get; set; }
    public string TeamsId { get; set; }
}