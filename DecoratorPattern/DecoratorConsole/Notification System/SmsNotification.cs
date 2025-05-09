namespace DecoratorConsole.Notification_System;

public class SmsNotification : INotifier
{
    public bool SendNotification(string message, string recipient)
    {
        Console.WriteLine($"Sending SMS to {recipient}: {message}");
        return true;
    }
}