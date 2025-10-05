using NotificationPrototype.Models;
using NotificationPrototype.NotificationStrategies;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddSingleton<INotificationStrategy, EmailNotification>();
services.AddSingleton<INotificationStrategy, TeamsNotification>();
services.AddSingleton<NotificationService>();

var provider = services.BuildServiceProvider();
var service = provider.GetRequiredService<NotificationService>();

var user = new User
{
    Email = "jelle@fontys.nl",
    TeamsId = "jelle_teams",
    NotificationPreferences = [NotificationType.Email, NotificationType.Teams]
};

await service.NotifyAsync(user, "Je reservering is bevestigd!");