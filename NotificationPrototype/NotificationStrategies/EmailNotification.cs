using NotificationPrototype.Models;

namespace NotificationPrototype.NotificationStrategies;

public class EmailNotification : INotificationStrategy
{
    public NotificationType Type => NotificationType.Email;

    public Task SendAsync(User user, string message)
    {
        Console.WriteLine($"Email gestuurd naar {user.Email} {message}");
        return Task.CompletedTask;
    }
}