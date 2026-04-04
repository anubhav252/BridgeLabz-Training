using System;
namespace FitnessTrackerBubbleSort
{
      class AppUtility: IAppOperation
    {
        public void UpdateData(Data[] data)
        {
            Console.WriteLine("Enter name ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter steps ");
            int steps=Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i].PersonName.Equals(name,StringComparison.OrdinalIgnoreCase))
                {
                    data[i]=new Data(name,steps);
                    break;
                } 
            }
            SortDataBySteps(data);
        }
        public void SortDataBySteps(Data[] data)
        {
            for(int i=0;i<data.Length-1;i++)
            {
                for(int j=0;j<data.Length-i-1;j++)
                {
                    if(data[j].StepsCount<data[j+1].StepsCount)
                    {
                        (data[j],data[j+1])=(data[j+1],data[j]);
                    }
                }
            }
            DisplayData(data);
        }
        public void DisplayData(Data[] data)
        {
            Console.WriteLine("-----leader board-----");
            for(int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"{i+1}. {data[i]}");
            }
        }

    } 
}