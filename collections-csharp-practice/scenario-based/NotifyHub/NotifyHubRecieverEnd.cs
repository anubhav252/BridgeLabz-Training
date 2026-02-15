
using System.ComponentModel.DataAnnotations;

namespace NotifyHub
{
    class NotifyHubRecieverEnd
    {
        private readonly NotificationQueue _queue = new();
    
        public void Receive(Notification notification)
        {
            try
            {
                NotificationValidator.Validate(notification);
                _queue.Enqueue(notification);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine($"Rejected: {ex.Message}");
            }
        }
    
        public NotificationQueue Queue => _queue;
    }
    
}

