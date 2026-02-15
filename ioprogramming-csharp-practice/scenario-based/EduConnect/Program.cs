using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string[] emails =
        {
            "john.doe@gmail.com",
            "megha_r92@outlook.in",
            "admin@blitz.edu",
            "john.doe@gmail",
            "@gmail.com",
            "raju#123@inbox.com"
        };

        await RegistrationProcessor.ProcessEmailsAsync(emails);
    }
}
