using System;
namespace NotifyHub
{
    public interface INotificationSender
    {
        Task SendAsync(Notification notification); 
    }

    //specific senders implementing INotificationSender
    public class EmailSender : INotificationSender
    {
        public async Task SendAsync(Notification notification)
        {
            await Task.Delay(200);
            System.Console.WriteLine($"Email sent to the {notification.Recipient}");
        }
    }
    public class SmsSender : INotificationSender
    {
        public async Task SendAsync(Notification notification)
        {
            await Task.Delay(120);
            System.Console.WriteLine($"Sms sent to the{notification.Recipient}");
        }
    }
    public class AppSender : INotificationSender
    {
        public async Task SendAsync(Notification notification)
        {
            await Task.Delay(50);
            System.Console.WriteLine($"alert sent to {notification.Recipient}");
        }
    }
}