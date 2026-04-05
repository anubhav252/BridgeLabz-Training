using System;
using System.Threading;
using System.Threading.Tasks;

namespace NotifyHub
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("NotifyHub started...\n");

            // Create NotifyHub (intake)
            var notifyHub = new NotifyHubRecieverEnd();

            // Cancellation token for graceful shutdown
            var cts = new CancellationTokenSource();

            // Create processor components
            var senderPicker = new SenderPicker();
            var processor = new NotificationProcessor(
                notifyHub.Queue,
                senderPicker,
                cts.Token
            );

            // start background workers (non-blocking)
            var processingTask = processor.StartAsync(workers: 3);

            // Send test notifications (intake)
            SendTestNotifications(notifyHub);

            // Let system run for a few seconds
            await Task.Delay(4000);

            // Stop processing
            cts.Cancel();
            await processingTask;

            Console.WriteLine("\nNotifyHub stopped.");
        }

        private static void SendTestNotifications(NotifyHubRecieverEnd hub)
        {
            // Valid notifications
            hub.Receive(new EmailNotification
            {
                NotificationId = Guid.NewGuid(),
                Recipient = "EMAIL:john@company.com",
                Message = "Welcome email",
                Priority = Notification.NotificationPriority.High
            });

            hub.Receive(new SmsNotification
            {
                NotificationId = Guid.NewGuid(),
                Recipient = "SMS:+123456789",
                Message = "OTP code",
                Priority = Notification.NotificationPriority.Low
            });

            hub.Receive(new AppNotification
            {
                NotificationId = Guid.NewGuid(),
                Recipient = "APP:user123",
                Message = "New app alert",
                Priority = Notification.NotificationPriority.Medium
            });

            // Invalid notification (missing recipient)
            hub.Receive(new EmailNotification
            {
                NotificationId = Guid.NewGuid(),
                Recipient = "",
                Message = "This will fail",
                Priority = Notification.NotificationPriority.Medium
            });

            // Invalid recipient format
            hub.Receive(new SmsNotification
            {
                NotificationId = Guid.NewGuid(),
                Recipient = "PHONE:99999",
                Message = "Invalid recipient",
                Priority = Notification.NotificationPriority.High
            });
        }
    }

}
