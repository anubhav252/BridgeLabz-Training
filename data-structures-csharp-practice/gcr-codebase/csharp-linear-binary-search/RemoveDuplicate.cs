using System;
using System.Text;

class RemoveDuplicate
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < result.Length; j++)
            {
                if (input[i] == result[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
                result.Append(input[i]);
        }

        Console.WriteLine(result.ToString());
    }
}
