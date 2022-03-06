﻿using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        //public List<Order> Orders = new List<Order>(); // read and write
        public readonly List<Order> Orders = new List<Order>(); // only read

        public Customer(int id)
        {
            Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>(); // if read and write
            /// ...
        }

    }
}
