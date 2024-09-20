using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InkapslingArvPolymorfism
{
    abstract class Animal
    {
        string Kind { get; set; }
        string Name { get; set; }
        int Weight { get; set; }
        int Age { get; set; }
        public Animal()
        {
            //    Kind = kind;
            //    Name = name;
            //    Weight = weight;
            //    Age = age;
        }

        // En abstrakt metod måste implementeras av underklasser
        internal abstract void DoSound();
        public virtual string Stats()
        {
            return $"Kind:{Kind} Name:{Name} Weight:{Weight} Age:{Age}";
        }

    }

    internal class Horse() : Animal
    {
        int Speed { get; set; }
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
        string Race { get; set; }
        internal override void DoSound()
        {
            Console.WriteLine("Wooof Woof");
        }

        public override string Stats()
        {
            return base.Stats() +$"Rece:{Race}";
        }
       
    }

    internal class Hedgehog : Animal
    {
        int NumberOfSpikes { get; set; }
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
        bool IsPisonous { get; set; }
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
        string Color { get; set; }
        internal override void DoSound()
        {
            Console.WriteLine("chioo chioo chioo");
        }

        public override string Stats()
        {
            return Color;
        }
    }

    internal class Wolf() : Animal
    {
        string Country { get; set;}
        internal override void DoSound()
        {
            Console.WriteLine("Aaooo Aaooo");
        }

        public override string Stats()
        {
            return Country;
        }
        

        
    }

    internal class Pelican() : Bird
    {
        string SeeName { get; set; }

    }

    internal class Flamingo() : Bird
    {
        int LegSize { get; set; }
    }

    internal class Swan() : Bird
    {
        double Wingspan { get; set; }

    }

    public interface IPerson
    {
        void Talk();
    }

    internal class Wolfman() : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("I am wolfman and I like wolfs");
        }
    }




}
