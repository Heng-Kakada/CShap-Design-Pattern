using DecoratorConsole.Notification_System;

namespace DecoratorConsole;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Testing Decorator Pattern");
        new NotificationApp().Running();
    }
}