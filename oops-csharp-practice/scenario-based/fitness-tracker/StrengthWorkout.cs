using FitnessTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class StrengthWorkout : Workout, ITrackable
    {
        private int reps;
        private double weight;

        public StrengthWorkout( int reps, double weight)
        {
            this.reps = reps;
            this.weight = weight;
        }
        public void StartWorkout()
        {
            Console.WriteLine("Starting Strength Workout!\n Doing Reps!");
        }
        public void CalculateCalories()
        {
            Console.WriteLine("Total Calorie Burned : " + (reps * weight * 5 ));
        }
    }
}
