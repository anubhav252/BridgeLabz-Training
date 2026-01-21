using System;
using System.Collections.Generic;

class VotingSystem
{
    static void Main()
    {
        Dictionary<string, int> voteCount = new Dictionary<string, int>();
        SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>();
        List<string> voteOrder = new List<string>();

        CastVote("Alice", voteCount, voteOrder);
        CastVote("Bob", voteCount, voteOrder);
        CastVote("Alice", voteCount, voteOrder);
        CastVote("Charlie", voteCount, voteOrder);
        CastVote("Bob", voteCount, voteOrder);

        Console.WriteLine("Vote Order:");
        foreach (string name in voteOrder)
            Console.Write(name + " ");

        Console.WriteLine("\n\nVote Count:");
        foreach (var pair in voteCount)
            Console.WriteLine(pair.Key + " : " + pair.Value);

        foreach (var pair in voteCount)
            sortedResults[pair.Key] = pair.Value;

        Console.WriteLine("\nSorted Results:");
        foreach (var pair in sortedResults)
            Console.WriteLine(pair.Key + " : " + pair.Value);
    }

    static void CastVote(string candidate,Dictionary<string, int> votes,List<string> order)
    {
        order.Add(candidate);

        if (votes.ContainsKey(candidate))
            votes[candidate]++;
        else
            votes[candidate] = 1;
    }
}
