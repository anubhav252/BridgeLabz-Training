using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class IPLMatch
{
    public int MatchId { get; set; }
    public string Team1 { get; set; }
    public string Team2 { get; set; }
    public string PlayerOfMatch { get; set; }
}

class IPLCensorshipAnalyzer
{
    static void Main()
    {
        ProcessJson();
        ProcessCsv();

        Console.WriteLine("Censored JSON and CSV files generated successfully.");
    }

    static void ProcessJson()
    {
        string jsonInput = File.ReadAllText("JsonInput.json");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        List<IPLMatch> matches =JsonSerializer.Deserialize<List<IPLMatch>>(jsonInput, options);

        foreach (var match in matches)
        {
            match.Team1 = MaskTeam(match.Team1);
            match.Team2 = MaskTeam(match.Team2);
            match.PlayerOfMatch = "REDACTED";
        }

        string censoredJson = JsonSerializer.Serialize( matches,new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText("ipl_censored.json", censoredJson);
    }

    static void ProcessCsv()
    {
        string[] lines = File.ReadAllLines("CsvInput.csv");
        List<string> output = new List<string>();

        output.Add(lines[0]); // header

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            data[1] = MaskTeam(data[1]);
            data[2] = MaskTeam(data[2]);
            data[3] = "REDACTED";

            output.Add(string.Join(",", data));
        }

        File.WriteAllLines("ipl_censored.csv", output);
    }

    static string MaskTeam(string team)
    {
        int index = team.IndexOf(' ');
        return index == -1 ? "***" : team.Substring(0, index) + " ***";
    }
}
