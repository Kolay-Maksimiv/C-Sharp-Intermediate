using System;
using System.Collections.Generic;

namespace Constructors
{
    class Program
    {

        static void Main(string[] args)
        {
            // №1
            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id); 
            Console.WriteLine(customer.Name);

            // №2
            var customer1 = new Customer();
            customer1.Id = 1; 
            customer1.Name = "John";
            Console.WriteLine(customer1.Id);
            Console.WriteLine(customer1.Name);

            // №3
            var customer2 = new Customer();
            customer2.Id = 1;
            customer2.Name = "John";

            var order = new Order();
            customer2.Orders.Add(order);

            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.Name);

        }
    }
}
