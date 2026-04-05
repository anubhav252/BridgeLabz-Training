using System;
using System.ComponentModel;
class LegacyAPI
{
    [Obsolete("Warning! use new feature")]
    public void OldMethod()
    {
        System.Console.WriteLine("old method");
    }
    public void NewMethod()
    {
        System.Console.WriteLine("new method");
    }
}
class Program
{
    static void Main(string[] args)
    {
        LegacyAPI call=new LegacyAPI();
        call.OldMethod();
        call.NewMethod();
    }
}