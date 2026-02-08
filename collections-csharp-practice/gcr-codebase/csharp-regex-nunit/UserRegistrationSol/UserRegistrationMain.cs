using System;

public class UserRegistration
{
    public bool RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Invalid username");

        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            throw new ArgumentException("Invalid email");

        if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            throw new ArgumentException("Invalid password");

        return true;
    }
}
