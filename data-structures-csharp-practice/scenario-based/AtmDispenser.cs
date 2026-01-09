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
            //int[] notes = { 1, 2, 5, 10, 20, 50, 100, 200 }; // Scenario B : temporarily removed 500 rupee note
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


        public void FallBackCombo(int amount) { // Scenario C: Display fallback combo if exact change isn’t possible.
            int[] notes = { 200,100 };
            int hasAmount = 0;
            int originalAmount = amount;
            for (int i = 0; i < notes.Length; i++)
            {
                int noOfNotes = amount / notes[i];
                if (noOfNotes > 0)
                {
                    hasAmount += noOfNotes * notes[i];
                    amount-= noOfNotes * notes[i];
                }
            }
            if (hasAmount != originalAmount)
            {
                Console.WriteLine("only " + hasAmount + " can be withdrawn don't have changes");
            }
        }
    }

    internal class AtmMain
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            AtmDispenser atm = new AtmDispenser();
            atm.GetNotes(amount);
            atm.FallBackCombo(amount);  
        }

    }
}
