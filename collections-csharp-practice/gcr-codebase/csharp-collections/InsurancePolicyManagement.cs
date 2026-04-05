using System;
using System.Collections.Generic;

class Policy
{
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Policy(string number, string coverage, DateTime expiry)
    {
        PolicyNumber = number;
        CoverageType = coverage;
        ExpiryDate = expiry;
    }

    public override bool Equals(object obj)
    {
        Policy p = obj as Policy;
        return p != null && PolicyNumber == p.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public override string ToString()
    {
        return $"{PolicyNumber} | {CoverageType} | {ExpiryDate:yyyy-MM-dd}";
    }
}

class ExpiryDateComparer : IComparer<Policy>
{
    public int Compare(Policy x, Policy y)
    {
        int result = x.ExpiryDate.CompareTo(y.ExpiryDate);
        if (result == 0)
            return x.PolicyNumber.CompareTo(y.PolicyNumber);
        return result;
    }
}

class Program
{
    static void Main()
    {
        HashSet<Policy> uniquePolicies = new HashSet<Policy>();
        List<Policy> insertionOrder = new List<Policy>();
        SortedSet<Policy> sortedByExpiry =new SortedSet<Policy>(new ExpiryDateComparer());

        AddPolicy(new Policy("P101", "Health",
            DateTime.Today.AddDays(20)),
            uniquePolicies, insertionOrder, sortedByExpiry);

        AddPolicy(new Policy("P102", "Vehicle",
            DateTime.Today.AddDays(60)),
            uniquePolicies, insertionOrder, sortedByExpiry);

        AddPolicy(new Policy("P103", "Home",
            DateTime.Today.AddDays(10)),
            uniquePolicies, insertionOrder, sortedByExpiry);

        AddPolicy(new Policy("P101", "Health",
            DateTime.Today.AddDays(20)),
            uniquePolicies, insertionOrder, sortedByExpiry);

        Console.WriteLine("All Unique Policies:");
        foreach (var p in uniquePolicies)
            Console.WriteLine(p);

        Console.WriteLine("\nInsertion Order:");
        foreach (var p in insertionOrder)
            Console.WriteLine(p);

        Console.WriteLine("\nSorted By Expiry Date:");
        foreach (var p in sortedByExpiry)
            Console.WriteLine(p);

        Console.WriteLine("\nExpiring Within 30 Days:");
        foreach (var p in uniquePolicies)
            if ((p.ExpiryDate - DateTime.Today).Days <= 30)
                Console.WriteLine(p);

        Console.WriteLine("\nCoverage Type = Health:");
        foreach (var p in uniquePolicies)
            if (p.CoverageType.Equals("Health",
                StringComparison.OrdinalIgnoreCase))
                Console.WriteLine(p);
    }

    static void AddPolicy(Policy policy,HashSet<Policy> set, List<Policy> ordered, SortedSet<Policy> sorted){
        if (set.Add(policy))
        {
            ordered.Add(policy);
            sorted.Add(policy);
        }
    }
}
