using System;

namespace Constructors_and_Inheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vegicle is initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vegicle is initialized.{0}", registrationNumber);
        }
    }
}
