using System;
using System.Reflection;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute
{
}
class EmailService
{
    public void SendEmail()
    {
        Console.WriteLine("Email sent successfully.");
    }
}
class UserService
{
    [Inject]
    private EmailService emailService;

    public void RegisterUser()
    {
        emailService.SendEmail();
    }
}

class DIContainer
{
    private Dictionary<Type, object> services =new Dictionary<Type, object>();

    public void Register<T>()
    {
        services[typeof(T)] = Activator.CreateInstance(typeof(T));
    }

    public T Resolve<T>()
    {
        object instance = Activator.CreateInstance(typeof(T));
        InjectDependencies(instance);
        return (T)instance;
    }

    private void InjectDependencies(object obj)
    {
        FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (FieldInfo field in fields)
        {
            if (field.GetCustomAttribute<InjectAttribute>() != null)
            {
                if (services.ContainsKey(field.FieldType))
                {
                    field.SetValue(obj, services[field.FieldType]);
                }
            }
        }
    }
}
class Program
{
    static void Main()
    {
        DIContainer container = new DIContainer();

        container.Register<EmailService>();

        UserService userService =container.Resolve<UserService>();

        userService.RegisterUser();
    }
}
