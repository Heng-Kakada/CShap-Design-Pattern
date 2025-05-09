namespace DecoratorConsole.Notification_System;
// primary constructor
public class LoggingDecorator(INotifier notifier) : INotifier
{
    public bool SendNotification(string message, string recipient)
    {
        Log(message, recipient);
        return notifier.SendNotification(message, recipient);
    }
    
    private static void Log(string message, string recipient)
    {
        var logEntry = $"{DateTime.Now} - Notification sent to {recipient} :{message}";
        Console.WriteLine($"Logging: {logEntry}");
    }
    
}