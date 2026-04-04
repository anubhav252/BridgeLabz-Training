using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalFactoryPipeCutting
{
    internal class Pipe
    {
        internal int PipeLength = 8;
        internal double[,] PriceChart = { { 1, 10 }, { 2, 15 }, { 3, 32 }, { 4, 35 } };
    }

    internal class PipeUtility
    {
        private Pipe pipe = new Pipe();
        //Scenario A
        public void GetMaxRevenue()
        {
            double maxRevenue = 0;

            for (int i = 0; i < pipe.PriceChart.GetLength(0); i++)
            {
                int cutLength = (int)pipe.PriceChart[i, 0];
                double price = pipe.PriceChart[i, 1];

                int temp = pipe.PipeLength;
                double revenue = 0;

                while (temp >= cutLength)
                {
                    revenue += price;
                    temp -= cutLength;
                }

                if (revenue > maxRevenue)
                {
                    maxRevenue = revenue;
                }
            }

            Console.WriteLine("Maximum Revenue = " + maxRevenue);
        }
        //Sceanrio B
        public void CustomLengthOrder(int[] order)
        {
            double revenue = 0;
            int sumOfPieces = 0;
            for(int i = 0; i < order.Length; i++)
            {
                sumOfPieces+= order[i];

            }
            if (sumOfPieces > pipe.PipeLength)
            {
                Console.WriteLine("length of pieces exceeds length of pipe");
                return;
            }
            for (int i = 0; i < order.Length; i++)
            {
                for (int j = 0; j < pipe.PriceChart.GetLength(0); j++)
                {
                    if (order[i] == pipe.PriceChart[j, 0])
                    {
                        revenue += pipe.PriceChart[j, 1];
                        break;
                    }
                }
            }

            Console.WriteLine("Revenue = " + revenue);
        }

        // Scenario C

        public void WithoutCutStrategy(int length)
        {
            double wholePrice = 70;
            Console.WriteLine("revenue : "+length*(wholePrice/8));
        }
    }

    internal class PipeMain
    {
        static void Main(string[] args)
        {
            PipeUtility pipe = new PipeUtility();
            pipe.GetMaxRevenue();

            Console.WriteLine("------------------");
            Console.WriteLine("Enter number of pieces:");
            int num = int.Parse(Console.ReadLine());

            int[] order = new int[num];
            Console.WriteLine("Enter length of pieces:");

            for (int i = 0; i < num; i++)
            {
                order[i] = int.Parse(Console.ReadLine());
            }

            pipe.CustomLengthOrder(order);

            Console.WriteLine("------------------------");
            Console.WriteLine("with out cut strategy \nenter length you want :");
            int length = int.Parse(Console.ReadLine()); 
            pipe.WithoutCutStrategy(length);
        }
    }
}
