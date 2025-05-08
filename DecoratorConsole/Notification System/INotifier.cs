namespace DecoratorConsole.Notification_System;

public interface INotifier
{
    public bool SendNotification(string message, string recipient);
}