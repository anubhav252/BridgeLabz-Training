using System;
namespace FitnessTrackerBubbleSort
{
    class Data
    {
        private string personName;
        private int stepsCount;
        public String PersonName
        {
            get { return personName; }
            set { personName = value; }
        }
        public int StepsCount
        {
            get { return stepsCount; }
            set { stepsCount = value; }
        }
        public Data(string name,int steps)
        {
            personName=name;
            stepsCount=steps;
        }
        public override string ToString()
        {
            return ($"Name : {PersonName}---Steps : {StepsCount}");
        }
    }
}