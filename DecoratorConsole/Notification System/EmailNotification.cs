namespace DecoratorConsole.Notification_System;

public class EmailNotification: INotifier
{
    public bool SendNotification(string message, string recipient)
    {
        Console.WriteLine($"Sending Email to {recipient}: {message}");
        return true;
    }
}