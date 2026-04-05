using System.Collections;
using System.Collections.Concurrent;
namespace NotifyHub
{
    class NotificationQueue
    {
        private PriorityQueue<Notification,int> Queue=new PriorityQueue<Notification,int>();
        private Object Lock=new();

        public void Enqueue(Notification notification)
        {
            lock(Lock){
                Queue.Enqueue(notification,-(int)notification.Priority);
            }
        }
        public bool TryDequeue(out Notification notification)
        {
            lock (Lock)
            {
                if (Queue.Count == 0)
                {
                    notification=null;
                    return false;
                }
                notification=Queue.Dequeue();
                return true;
            }
        }

        
    }
}