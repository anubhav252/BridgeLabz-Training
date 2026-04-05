using System;

class UserActions
{
    [AuditTrail("User Login")]
    public void Login()
    {
        Console.WriteLine("User logged in");
    }

    [AuditTrail("File Upload")]
    public void UploadFile()
    {
        Console.WriteLine("File uploaded");
    }

    [AuditTrail("File Delete")]
    public void DeleteFile()
    {
        Console.WriteLine("File deleted");
    }

    public void ViewProfile()
    {
        Console.WriteLine("Profile viewed");
    }
}
