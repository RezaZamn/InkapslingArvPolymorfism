using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InkapslingArvPolymorfism
{
    abstract class Animal
    {
        //private string kind;
        //private string name;
        //private int weight;
        //private int age;

        public string Kind { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public Animal(string kind, string name, int weight, int age)
        {
            Kind = kind;
            Name = name;
            Weight = weight;
            Age = age;
        }

        // En abstrakt metod måste implementeras av underklasser
        internal abstract void DoSound();
        public virtual string Stats()
        {
            return $"Kind:{Kind} Name:{Name} Weight:{Weight} Age:{Age}";
        }

    }

    internal class Horse : Animal

    {
        public int Speed { get; set; }

        public Horse(string kind, string name, int weight, int age, int speed)
              : base(kind, name, weight, age)
        {
            Speed = speed;
        }
        internal override void DoSound()
        {
            Console.WriteLine("Yyiiiihheeeeeheehheee");
        }

        public override string Stats()
        {
            return base.Stats() + $"Speed:{Speed}";
        }
    }

    internal class Dog : Animal
    {
        public string Race { get; set; }

        public Dog(string kind, string name, int weight, int age, string race)
            : base(kind, name, weight, age)
        {

            Race = race;
        }
        internal override void DoSound()
        {
            Console.WriteLine("Wooof Woof");
        }

        public override string Stats()
        {
            return base.Stats() + $" Rece:{Race}";
        }

        public string TestMetod()
        {
            return "Det här är en valfri text";
        }

    }

    internal class Hedgehog : Animal
    {
        public int NumberOfSpikes { get; set; }
        public Hedgehog(string kind, string name, int weight, int age, int numberOfSpikes)
            : base(kind, name, weight, age)
        {
            NumberOfSpikes = numberOfSpikes;
        }

        internal override void DoSound()
        {
            Console.WriteLine("yyihi yyhi");
        }

        public override string Stats()
        {
            return base.Stats() + $"NumberOfSpikes:{NumberOfSpikes}";
        }
    }

    internal class Worm : Animal
    {
        public bool IsPisonous { get; set; }

        public Worm(string kind, string name, int weight, int age, bool isPisonous)
            : base(kind, name, weight, age)
        {
            IsPisonous = isPisonous;
        }
        internal override void DoSound()
        {
            Console.WriteLine("No Sound");
        }

        public override string Stats()
        {
            return base.Stats() + $"IsPisonous: {IsPisonous}";

        }
    }

    internal class Bird : Animal
    {
        public string Color { get; set; }

        public Bird(string kind, string name, int weight, int age, string color)
            : base(kind, name, weight, age)
        {
            Color = color;
        }

        internal override void DoSound()
        {
            Console.WriteLine("chioo chioo chioo");
        }

        public override string Stats()
        {
            return base.Stats() + $" Color: {Color}";
        }
    }

    internal class Wolf : Animal
    {
        public string Origin { get; set; }


        public Wolf(string kind, string name, int weight, int age, string origin)
            : base(kind, name, weight, age)
        {
            Origin = origin;
        }



        internal override void DoSound()
        {
            Console.WriteLine("Aaooo Aaooo");
        }

        public override string Stats()
        {
            return base.Stats() + $" Origin {Origin}";
        }



    }

    internal class Pelican : Bird
    {
        public string SeeName { get; set; }

        public Pelican(string kind, string name, int weight, int age, string color, string seeName)
            : base(kind, name, weight, age, color)
        {
            SeeName = seeName;
        }
    }

        internal class Flamingo : Bird
        {
            int LegSize { get; set; }

            public Flamingo(string kind, string name, int weight, int age, string color, int legSize)
                : base(kind, name, weight, age, color)
            {
                LegSize = legSize;
            }

        }

        internal class Swan : Bird
        {
            double Wingspan { get; set; }

            public Swan(string kind, string name, int weight, int age, string color, double wingspan)
                : base(kind, name, weight, age, color)
            {
                Wingspan = wingspan;
            }

        }

        public interface IPerson
        {
            void Talk();
        }

        internal class Wolfman : Wolf, IPerson
        {
            public Wolfman(string kind, string name, int weight, int age, string origin)
                : base(kind, name, weight, age, origin) { }



            public void Talk()
            {
                Console.WriteLine("I am wolfman and I like wolfs");
            }
        }




    
}
