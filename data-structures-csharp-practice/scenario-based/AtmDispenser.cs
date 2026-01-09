using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Tracker
{
    internal class AtmDispenser
    {
        public void GetNotes(int amount)
        {
            int noOfNotes = 0;
            int[] notes = { 1, 2, 5, 10, 20, 50, 100, 200, 500 }; // Scenario A
            for (int i = notes.Length - 1; i >= 0; i--)
            {
                if (amount!=0)
                {
                    Console.WriteLine(notes[i]+" Rs notes : "+ (amount / notes[i])); 
                    noOfNotes+= amount / notes[i];
                    amount = amount - (notes[i] * (amount / notes[i]));
                }
            }
            Console.WriteLine("total no of notes : "+noOfNotes);

        }
        
    }
    internal class AtmMain
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            AtmDispenser atm = new AtmDispenser();
            atm.GetNotes(amount);
        }

    }
}
