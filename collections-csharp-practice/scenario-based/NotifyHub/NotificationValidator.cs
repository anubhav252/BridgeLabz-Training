using System.ComponentModel.DataAnnotations;

namespace NotifyHub
{
    static class NotificationValidator
    {
        public static void Validate(Notification notification)
        {
            var context=new ValidationContext(notification);
            Validator.ValidateObject(notification,context,true);
        }
    }
}