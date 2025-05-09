namespace DecoratorConsole.Notification_System;

public class FormattingDecorator(INotifier notifier, string prefix = "[ALERT]") : INotifier
{
    private readonly string _prefix = prefix;
    
    public bool SendNotification(string message, string recipient)
    {
        var format = this.FormatMessage(message);
        return notifier.SendNotification(format, recipient);
    }

    private string FormatMessage(string message)
    {
        return $"{_prefix} {message}";
    }
}