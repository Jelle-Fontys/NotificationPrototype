using NotificationPrototype.Models;

namespace NotificationPrototype.NotificationStrategies;

public class TeamsNotification : INotificationStrategy
{
    public NotificationType Type => NotificationType.Teams;

    public Task SendAsync(User user, string message)
    {
        Console.WriteLine($"Teamsbericht gestuurd naar {user.TeamsId}: {message}");
        return Task.CompletedTask;
    }
}