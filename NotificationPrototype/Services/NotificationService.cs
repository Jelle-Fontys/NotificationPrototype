using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NotificationPrototype.Models;
using NotificationPrototype.NotificationStrategies;

public class NotificationService
{
    private readonly IDictionary<NotificationType, INotificationStrategy> _strategies;

    public NotificationService(IEnumerable<INotificationStrategy> strategies)
    {
        _strategies = new Dictionary<NotificationType, INotificationStrategy>();
        foreach (var strategy in strategies)
        {
            _strategies[strategy.Type] = strategy;
        }
    }

    public async Task NotifyAsync(User user, string message)
    {
        foreach (var type in user.NotificationPreferences)
        {
            if (_strategies.TryGetValue(type, out var strategy))
            {
                await strategy.SendAsync(user, message);
            }
        }
    }
}