using System;

namespace Classes
{
    /// <summary>
    /// Declaring Class
    /// </summary>
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating Objects
            Person person1 = new Person();
            //or
            var person2 = new Person();


            // Using Objects
            person1.Name = "John";
            person1.Introduce("Mosh");

            /////
            var person3 = Person.Parse("Mykola");
            person3.Introduce("John");


        }
    }


}



