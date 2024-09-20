using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapslingArvPolymorfism
{
    internal class PersonHandler
    {
        Person person = new Person();
        public void SetAge(Person pers, int age)
        {

            if (age > 0)
            {
                pers.Age = age;
            }


        }


        public Person CreatePerson(int age, string fname, string lname, int height, int weight)
        {
            Person newPerson = new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight

            };            
            return newPerson;
        }

        public void PrintUtPerson(Person person)
        {
            Console.WriteLine($"Age: {person.Age}, First Name: {person.FName}, " +
                $"Last Name: {person.LName}, Height: {person.Height}, Weight: {person.Weight}"); 
        }
    }
}
