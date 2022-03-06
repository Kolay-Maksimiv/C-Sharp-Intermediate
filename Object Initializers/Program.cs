using System;

namespace Object_Initializers
{
    class Program
    {
        public class Person
        {
            public int Id;
            public string FirstName;
            public string LastNama;
            public DateTime Birthdate;
            public Person() { }
            public Person(int id) { }
            public Person(int id, string firstName) { }
            public Person(int id, string firstName, string lastName) { }
            public Person(int id, DateTime birthdate) { }


        }

        static void Main(string[] args)
        {
            var person = new Person()
            {
                Id = 1,
                FirstName = "Mykola",
                LastNama = "Maksymiv"
            };
        }
    }
}
