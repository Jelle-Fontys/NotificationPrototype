using NotificationPrototype.Models;

namespace NotificationPrototype.NotificationStrategies;

public interface INotificationStrategy
{
    NotificationType Type { get; }
    Task SendAsync(User user, string message);
}