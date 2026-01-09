using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class TrackerMain
    {
        static void Main(string[] args)
        {
            UserProfile user1 = new UserProfile();
            user1.Name = "Sam";
            user1.Age = 21;
            user1.Weight = 60;
            user1.Height = 175;
            Console.WriteLine(user1); 

            ITrackable w = new CardioWorkout(user1,5);
            w.StartWorkout();
            w.CalculateCalories();

            ITrackable w2 = new StrengthWorkout(5,10);
            w2.StartWorkout();
            w2.CalculateCalories();
        }
    }
}
