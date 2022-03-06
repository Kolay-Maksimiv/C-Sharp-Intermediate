using System;

namespace Properties
{

    class Program
    {
        static void Main(string[] args)
        {
            // var person = new Person();
            // person.Birthdate = new DateTime(1999, 12, 16);
            // Console.WriteLine(person.Age);

            var person = new Person(new DateTime(1999, 12, 16));
            Console.WriteLine(person.Age);
        }
    }
}
