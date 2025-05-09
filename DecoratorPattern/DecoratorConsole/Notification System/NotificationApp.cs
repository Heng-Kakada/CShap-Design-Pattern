namespace DecoratorConsole.Notification_System;

public class NotificationApp
{
    public void Running()
    { 
        var emailNotification = new EmailNotification();
        // var emailDecorator = new FormattingDecorator(emailNotification, "[Alert]");
        // var emailDecorator2 = new LoggingDecorator(emailDecorator);

        var emailDecorator = new LoggingDecorator(emailNotification);
        var emailDecorator2 = new FormattingDecorator(emailDecorator, "[Alert]");
        
        
        
        var recipient = "user@emaxple.com";
        for (var i = 1; i <= 10; i++)
        {
            var result = emailDecorator2.SendNotification("Hello World", recipient);
            if (i == 5)
            {
                // emailDecorator = new FormattingDecorator(emailNotification, "[Warning]");
                // emailDecorator2 = new LoggingDecorator(emailDecorator);
                 emailDecorator = new LoggingDecorator(emailNotification);
                 emailDecorator2 = new FormattingDecorator(emailDecorator, "[Warning]");
            }
            Thread.Sleep(2000);
        }
    }
}