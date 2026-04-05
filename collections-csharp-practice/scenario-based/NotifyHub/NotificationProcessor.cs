using NotifyHub;

namespace NotifyHub
{
    class NotificationProcessor
    {
        private NotificationQueue Queue;
        private ISenderPicker Picker;
        private CancellationToken Token;
        public NotificationProcessor(NotificationQueue queue,ISenderPicker picker,CancellationToken token)
        {
            Queue=queue;
            Picker=picker;
            Token=token;
        }
        public async Task StartAsync(int workers=4)
        {
            var tasks=Enumerable.Range(0,workers).Select(_ => Task.Run(ProcessAsync,Token));

            await Task.WhenAll(tasks);
        }
        public async Task ProcessAsync()
        {
            while (!Token.IsCancellationRequested)
            {
                if(!Queue.TryDequeue(out Notification notification))
                {
                    await Task.Delay(50);
                    continue;
                }
                try
                {
                    var sender=Picker.Resolve(notification);
                    await sender.SendAsync(notification);
                    notification.Status=Notification.NotificationStatus.Sent;
                }
                catch(Exception ex)
                {
                    notification.Status=Notification.NotificationStatus.Failed;
                    System.Console.WriteLine("Failed : "+ex.Message);
                }
            }
        }
    }
}