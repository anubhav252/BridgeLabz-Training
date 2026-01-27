using System;

[AttributeUsage(AttributeTargets.Method)]
public class PublicAPIAttribute : Attribute
{
}

[AttributeUsage(AttributeTargets.Method)]
public class RequiresAuthAttribute : Attribute
{
    public string Role { get; }

    public RequiresAuthAttribute(string role)
    {
        Role = role;
    }
}
