using System;
using System.Reflection;
public interface IGreeting
{
    void SayHello(string name);
}
public class GreetingService : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine("Hello, " + name);
    }
}


public class LoggingProxy<T> : DispatchProxy
{
    private T target;

    public void SetTarget(T targetObject)
    {
        target = targetObject;
    }

    protected override object Invoke(MethodInfo method, object[] args)
    {
        Console.WriteLine("Calling method: " + method.Name);
        return method.Invoke(target, args);
    }
}
class Program
{
    static void Main()
    {
        IGreeting service = new GreetingService();

        IGreeting proxy =DispatchProxy.Create<IGreeting, LoggingProxy<IGreeting>>();

        ((LoggingProxy<IGreeting>)proxy).SetTarget(service);

        proxy.SayHello("Rahul");
    }
}
