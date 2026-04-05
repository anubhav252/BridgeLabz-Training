using System;
using System.Reflection;

class HealthCheckPro
{
    public static void ScanAPIs()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        foreach (Type type in assembly.GetTypes())
        {
            if (!type.Name.EndsWith("Controller"))
                continue;

            Console.WriteLine("Controller: " + type.Name);

            MethodInfo[] methods =type.GetMethods(BindingFlags.Instance |BindingFlags.Public |BindingFlags.DeclaredOnly);

            foreach (MethodInfo method in methods)
            {
                bool isPublicApi =method.GetCustomAttribute<PublicAPIAttribute>() != null;

                RequiresAuthAttribute auth =method.GetCustomAttribute<RequiresAuthAttribute>();

                Console.Write(" - " + method.Name);

                if (isPublicApi)
                    Console.Write("  [PublicAPI]");
                else
                    Console.Write("Missing PublicAPI");

                if (auth != null)
                    Console.Write($"  [RequiresAuth: {auth.Role}]");

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
