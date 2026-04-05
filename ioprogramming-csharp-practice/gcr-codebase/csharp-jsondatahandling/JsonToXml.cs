using System;
using System.IO;
using Newtonsoft.Json;
using System.Xml;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("data.json");

        XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode(json);

        xmlDoc.Save("data.xml");

        Console.WriteLine("JSON converted to XML successfully.");
    }
}
