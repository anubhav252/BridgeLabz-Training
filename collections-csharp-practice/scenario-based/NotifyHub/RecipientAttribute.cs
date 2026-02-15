using System.ComponentModel.DataAnnotations;

namespace NotifyHub
{
    class RecipientAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext context)
        {
            string recipient=(string)value;
            if (!recipient.StartsWith("EMAIL:")&& !recipient.StartsWith("SMS:")&& !recipient.StartsWith("APP:"))
            {    
                return new ValidationResult("Invalid recipient format.");
            }
            return ValidationResult.Success;
        }
    }
}