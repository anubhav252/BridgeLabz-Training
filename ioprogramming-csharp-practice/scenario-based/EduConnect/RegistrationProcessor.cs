using System;
using System.Threading.Tasks;

public static class RegistrationProcessor
{
    public static async Task ProcessEmailsAsync(string[] emails)
    {
        var tasks = new List<Task>();

        foreach (var email in emails)
        {
            tasks.Add(Task.Run(() =>
            {
                try
                {
                    var student = new Student { Email = email };

                    if (EmailService.ValidateStudent(student, out string error))
                    {
                        Console.WriteLine($"Valid: {email}");
                        FileLogger.Log("valid_emails.txt", email);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid: {email} - {error}");
                        FileLogger.Log("invalid_emails.txt", $"{email} - {error}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing {email}: {ex.Message}");
                }
            }));
        }

        await Task.WhenAll(tasks);
    }
}
