namespace NotifyHub
{
    interface ISenderPicker
    {
        INotificationSender Resolve(Notification notification);
    }
    class SenderPicker : ISenderPicker
    {
        public INotificationSender Resolve(Notification notification)
        {
            switch (notification)
            {
                case EmailNotification:
                    {
                        return new EmailSender();
                    }
                case SmsNotification:
                    {
                        return new SmsSender();
                    }
                case AppNotification:
                    {
                        return new AppSender();
                    }
                default:
                    {
                        throw new NotSupportedException();
                    }
            }
        }
    }
}