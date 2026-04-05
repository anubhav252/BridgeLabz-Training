using System;
namespace BirdSanctuarySystem
{
    internal interface IFlyable
    {
        void Fly();
    }
    internal interface ISwimmable
    {
        void Swim();
    }

    internal class Bird
    {
        private string birdName;

        public Bird(string birdName)
        {
            this.birdName = birdName;
        }
        public override string ToString()
        {
            return (birdName+" : ");
        }
    }

    internal class Eagle : Bird,IFlyable
    {
        public Eagle(string birdName) : base(birdName) { }

        public void Fly()
        {
            Console.Write("can Fly");
        }
    }

    internal class SeaGull : Bird,IFlyable,ISwimmable
    {
        public SeaGull(string birdName) : base(birdName) { }

        public void Fly()
        {
            Console.Write("can Fly"); 
        }
        public void Swim()
        {
            Console.Write("can Swim"); 
        }
    }

    internal class Duck : Bird,ISwimmable
    {
        public Duck(string birdName) : base(birdName) { }

        public void Swim()
        {
            Console.Write("can Swim");
        }
    }

    internal class Penguin : Bird,ISwimmable
    {

        public Penguin(string birdName) : base(birdName) { }

        public void Swim()
        {
            Console.Write("can Swim");
        }
    }

    internal class Sparrow : Bird,IFlyable
    {
        public Sparrow(string birdName) : base(birdName) { }

        public void Fly()
        {
            Console.Write("can Fly");
        }
    }

    internal class Programm
    {
        static void Main(string[] args)
        {
            Bird[] birds = { new Eagle("Eagle"), new Duck("Duck"), new Sparrow("Sparrow"), new Penguin("Penguin"), new SeaGull("SeaGull") };

            foreach(Bird bird in birds)
            {
               IFlyable flyable = bird as IFlyable;
               if (flyable != null)
               {
                   Console.Write(bird);
                   flyable.Fly();
                   Console.WriteLine();
               }
	           
               ISwimmable swimmable = bird as ISwimmable;
               if (swimmable != null)
               {
                   Console.Write(bird);
                   swimmable.Swim();
                   Console.WriteLine();
               }     
			}
		}
	}
}
