using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

static class EmailService
{
    public static bool ValidateStudent(Student student, out string error)
    {
        var context = new ValidationContext(student);
        var results = new List<ValidationResult>();

        bool isValid = Validator.TryValidateObject(student, context, results, true);

        error = isValid ? null : results[0].ErrorMessage;
        return isValid;
    }
}
