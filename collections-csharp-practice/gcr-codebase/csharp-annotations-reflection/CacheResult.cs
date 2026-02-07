using System;
using System.Reflection;
using System.Collections.Generic;
using System.Threading;

[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute
{
}
class MathService
{
    [CacheResult]
    public int CalculateSquare(int number)
    {
        Console.WriteLine("Computing square");
        Thread.Sleep(2000); 
        return number * number;
    }
}

class CacheExecutor
{
    private static Dictionary<string, object> cache =new Dictionary<string, object>();

    public static object Invoke(object obj, string methodName, object[] parameters)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method.GetCustomAttribute<CacheResultAttribute>() != null)
        {
            string cacheKey = methodName + "_" + string.Join("_", parameters);

            if (cache.ContainsKey(cacheKey))
            {
                Console.WriteLine("Returning cached result.");
                return cache[cacheKey];
            }

            object result = method.Invoke(obj, parameters);
            cache[cacheKey] = result;
            return result;
        }

        return method.Invoke(obj, parameters);
    }
}

class Program
{
    static void Main()
    {
        MathService service = new MathService();

        Console.WriteLine(CacheExecutor.Invoke(service, "CalculateSquare", new object[] { 5 }));
        Console.WriteLine(CacheExecutor.Invoke(service, "CalculateSquare", new object[] { 5 }));
        Console.WriteLine(CacheExecutor.Invoke(service, "CalculateSquare", new object[] { 6 }));
    }
}
