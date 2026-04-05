using FitnessTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class CardioWorkout : Workout, ITrackable
    {
        private UserProfile user;
        private double distance;
        //private double speed;

        //public double Distance { get { return distance; } set { distance = value; } }

        public CardioWorkout(UserProfile user, double distance)
        {
            this.user = user;
            this.distance = distance;
        }
       
        //public double Speed { get { return speed; } set { speed = value; } }

        //public CardioWorkout(string name, double duration, double distance, double speed) : base(name, duration)
        //{
        //    this.distance = distance;
        //    this.speed = speed;
        //}

        public void StartWorkout()
        {
            Console.WriteLine("Starting Workout!\nRunning..");
        }
        public void CalculateCalories()
        {
            Console.WriteLine("Total Calorie Burned : " + (user.Weight * distance ));
        }
    }
}
