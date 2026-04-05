using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
class EmailValidatorAtrribute : ValidationAttribute
{
    protected override ValidationResult IsValid(Object value,ValidationContext context)
    {
        string pattern=@"^[a-zA-Z0-9._]+@[a-zA-Z]+\.(com|in|org|edu)$";
        if (value == null)
            return new ValidationResult("Email is required.");

        var email = value.ToString();

        if (!Regex.IsMatch(email,pattern))
            return new ValidationResult("Invalid email format.");

        return ValidationResult.Success;
    }
}