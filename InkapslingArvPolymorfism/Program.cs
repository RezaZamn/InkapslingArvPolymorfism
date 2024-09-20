using System.Net.Cache;

namespace InkapslingArvPolymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------------------------------------------3.1) Inkapsling
            Person person = new Person();
            person.Age = 0;
            person.FName = "Leo";
            person.LName = "Davinci";

            PersonHandler handler = new PersonHandler();

            handler.SetAge(person, 12);
            Person p = handler.CreatePerson(14, "Leor", "Ross", 154, 45);
            handler.PrintUtPerson(p);

            Person p1 = handler.CreatePerson(15, "laloo", "lilo", 163, 54);
            handler.PrintUtPerson(p1);

            int value = person.Age;
            Console.WriteLine(value);

            try
            {
                if (person.Age <= 0)
                    throw new ArgumentException("Age kan bara ett värde som är större än 0");
                Console.WriteLine("Age inputvärde är giltig.");

            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Fel: " + ex.Message);

            }


            try
            {

                if (person.FName.Length > 10 || person.FName.Length < 2)
                    throw new ArgumentException("FName ska inte vara mindre än 2 tecken eller längre än 10 tecken");
                Console.WriteLine("FName inputvärde är giltig.");

            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Fel: " + ex.Message);

            }


            try
            {

                if (person.LName.Length < 3 || person.LName.Length > 15)
                    throw new ArgumentException("LName ska inte vara mindre än 3 tecken eller längre än 15 tecken");
                Console.WriteLine("LName inputvärde är giltig.");

            }

            catch (ArgumentException ex)
            {
                Console.WriteLine("Fel: " + ex.Message);

            }


            //---------------------------------------------3.2) Polymorfism 

            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();

            string t1 = numericInputError.UEMessage();
            string t2 = textInputError.UEMessage();

            Console.WriteLine(t1);
            Console.WriteLine(t2);



            List<UserError> errorsList = new List<UserError>();

            ////UserError numericInputError = new NumericInputError();
            ////UserError textInputError = new TextInputError();

            errorsList.Add(numericInputError);
            errorsList.Add(textInputError);
            errorsList.Add(new EgenKlass1());
            errorsList.Add(new EgenKlass2());
            errorsList.Add(new EgenKlass3());

            foreach (UserError error in errorsList)
            {
                Console.WriteLine(error.UEMessage());

            }


            //---------------------------------------------3.3) Arv

            List<Animal> animals = new List<Animal>();

            animals.Add(new Horse());
            animals.Add(new Dog());
            animals.Add(new Hedgehog());
            animals.Add(new Worm());
            animals.Add(new Bird());
            animals.Add(new Wolf());


            foreach (Animal anim in animals)
            {
                anim.DoSound();
            }



            //---------------------------------------------3.4) Mer polymorfism

            List<Animal> animals1 = new List<Animal>();

            
            animals1.Add(new Wolf());
            animals1.Add(new Bird());
            animals1.Add(new Worm());

            foreach (Animal animal in animals1)
            {
                Console.WriteLine(animal);
            }


        }
    }
}
