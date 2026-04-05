using System;
using System.ComponentModel.DataAnnotations;
namespace NotifyHub
{
    public abstract class Notification
    {
        [Required(ErrorMessage ="Id is Required")]
        public Guid NotificationId{get; set;}

        [Required]
        [Recipient]
        public string Recipient{get;set;}

        [StringLength(400)]
        public string Message{get;set;}

        [EnumDataType(typeof(NotificationPriority))]
        public NotificationPriority Priority{get; set;}
        public DateTime CreatedAt{get;set;}=DateTime.Now;
        public NotificationStatus Status { get; set; } = NotificationStatus.Pending;

        public enum NotificationPriority
        {
            Low=1,
            Medium=2,
            High=3
        }
        public enum NotificationStatus
        {
            Pending,
            Sent,
            Failed
        }
    }
    public class EmailNotification:Notification{}
    public class SmsNotification:Notification{}
    public class AppNotification:Notification{}
}