using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}
class AdminOperations
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User deleted successfully.");
    }

    public void ViewUsers()
    {
        Console.WriteLine("Viewing users.");
    }
}

class Program
{
    static void Main()
    {
        string currentUserRole = "USER"; 

        AdminOperations obj = new AdminOperations();
        Type type = typeof(AdminOperations);

        MethodInfo method = type.GetMethod("DeleteUser");

        RoleAllowedAttribute attr =method.GetCustomAttribute<RoleAllowedAttribute>();

        if (attr != null)
        {
            if (attr.Role == currentUserRole)
            {
                method.Invoke(obj, null);
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
        }
        else
        {
            method.Invoke(obj, null);
        }
    }
}
