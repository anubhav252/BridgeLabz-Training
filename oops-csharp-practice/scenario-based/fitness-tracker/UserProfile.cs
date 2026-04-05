using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class UserProfile
    {
        private string name;
        private int age;
        private double weight;
        private double height;

        public string Name { get { return name; }
            set { name = value; }
        }
        public int Age { get { return age; }
            set { age = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        //public UserProfile(string name, int age, double weight, double height)
        //{
        //    this.name = name;
        //    this.age = age;
        //    this.weight = weight;
        //    this.height = height;
        //}
        public override string ToString()
        {
            return ($"Name : {name}\nAge : {age}\nWeight : {weight}\nHeight : {height}");
        }
    }
}
