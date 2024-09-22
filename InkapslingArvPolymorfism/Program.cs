using System.Net.Cache;
using System.Xml.Linq;

namespace InkapslingArvPolymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------------------------------------------3.1) Inkapsling
            //Person person = new Person();
            //person.Age = 0;
            //person.FName = "Leo";
            //person.LName = "Davinci";

            //PersonHandler handler = new PersonHandler();

            //handler.SetAge(person, 12);
            //Person p = handler.CreatePerson(14, "Leor", "Ross", 154, 45);
            //handler.PrintUtPerson(p);

            //Person p1 = handler.CreatePerson(15, "laloo", "lilo", 163, 54);
            //handler.PrintUtPerson(p1);

            //int value = person.Age;
            //Console.WriteLine(value);

            //try
            //{
            //    if (person.Age <= 0)
            //        throw new ArgumentException("Age kan bara ett värde som är större än 0");
            //    Console.WriteLine("Age inputvärde är giltig.");

            //}

            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Fel: " + ex.Message);

            //}


            //try
            //{

            //    if (person.FName.Length > 10 || person.FName.Length < 2)
            //        throw new ArgumentException("FName ska inte vara mindre än 2 tecken eller längre än 10 tecken");
            //    Console.WriteLine("FName inputvärde är giltig.");

            //}

            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Fel: " + ex.Message);

            //}


            //try
            //{

            //    if (person.LName.Length < 3 || person.LName.Length > 15)
            //        throw new ArgumentException("LName ska inte vara mindre än 3 tecken eller längre än 15 tecken");
            //    Console.WriteLine("LName inputvärde är giltig.");

            //}

            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Fel: " + ex.Message);

            //}


            //---------------------------------------------3.2) Polymorfism 

            //NumericInputError numericInputError = new NumericInputError();
            //TextInputError textInputError = new TextInputError();

            //string t1 = numericInputError.UEMessage();
            //string t2 = textInputError.UEMessage();

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);



            //List<UserError> errorsList = new List<UserError>();

            ////UserError numericInputError = new NumericInputError();
            ////UserError textInputError = new TextInputError();

            //errorsList.Add(numericInputError);
            //errorsList.Add(textInputError);
            //errorsList.Add(new EgenKlass1());
            //errorsList.Add(new EgenKlass2());
            //errorsList.Add(new EgenKlass3());

            //foreach (UserError error in errorsList)
            //{
            //    Console.WriteLine(error.UEMessage());

            //}


            //---------------------------------------------3.3) Arv

            //List<Animal> animals = new List<Animal>();

            //animals.Add(new Horse());
            //animals.Add(new Dog());
            //animals.Add(new Hedgehog());
            //animals.Add(new Worm());
            //animals.Add(new Bird());
            //animals.Add(new Wolf());


            //foreach (Animal anim in animals)
            //{
            //    anim.DoSound();
            //}



            //---------------------------------------------3.4) Mer polymorfism

            //List<Animal> animals1 = new List<Animal>();
            //Wolf wolf = new Wolf("Wolf", "Wolfy", 43, 9, "sweden");
            //Bird bird = new Bird("Bird", "canari", 1, 3, "Yellow");
            //Pelican pelican = new Pelican("Pelican", "BigJojo", 10, 4, "White", "Caribbean");
            //Wolfman wolfMan = new Wolfman("Human", "Wolfiman", 12, 8, "India");

            //animals1.Add(wolf);
            //animals1.Add(bird);
            //animals1.Add(pelican);
            //animals1.Add(wolfMan);

            //foreach (Animal animal in animals1)
            //{
            //    Console.WriteLine(animal.Stats());
            //    animal.DoSound();

            //    if (animal is IPerson person)
            //    {
            //        person.Talk();
            //    }
            //}

            //List<Dog> dog = new List<Dog>();
            //Horse horse = new Horse("Horse", "Browney", 170, 7, 70);
            //dog.Add(horse);


            List<Animal> allAnimals = new List<Animal>();
            Horse horse1 = new Horse("Horse", "Boney", 180, 9, 73);
            Dog dog1 = new Dog("dog", "Bell", 27, 7, "German");
            Hedgehog hedgehog = new Hedgehog("Hegehog", "Knify", 4, 2, 324);
            Worm worm = new Worm("Worm", "Roppe", 1, 1, false);
            Bird bird1 = new Bird("Bird", "canari", 1, 3, "Yellow");
            Wolf wolf1 = new Wolf("Wolf", "Woljkhfy", 43, 9, "sweden");
            Pelican pelican1 = new Pelican("Pelican", "BigJojo", 10, 4, "White", "Caribbean");
            Flamingo flamingo = new Flamingo("Flamingo", "Fely", 17, 3, "White", 1);
            Wolfman wolfMan1 = new Wolfman("Human", "Wolfiman", 12, 8, "India");
            Swan swan = new Swan("Swan", "Susy", 23, 4, "White", 1.84);

            allAnimals.Add(horse1);
            allAnimals.Add(dog1);
            allAnimals.Add(hedgehog);
            allAnimals.Add(worm);
            allAnimals.Add(bird1);
            allAnimals.Add(wolf1);
            allAnimals.Add(pelican1);
            allAnimals.Add(flamingo);
            allAnimals.Add(wolfMan1);
            allAnimals.Add(swan);

            foreach (Animal allAnimal in allAnimals)
            {
                Console.WriteLine(allAnimal.Stats());
            }

            Console.WriteLine();

            foreach (Animal animal in allAnimals)
            {
                if (animal is Dog)
                    Console.WriteLine(animal.Stats());
            }

            Console.WriteLine();

            foreach (Animal animal in allAnimals)
            {
                if (animal is Dog dog)
                    Console.WriteLine(dog.TestMetod());
            }




        }
    }
}
