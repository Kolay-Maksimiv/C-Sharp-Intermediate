using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing_and_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1); // int
            list.Add("Mykola"); // string
            list.Add(DateTime.Today); // Date Time

            var anotherList = new List<int>();
            //anotherList.Add(); // int list
            var names = new List<string>();
            //names.Add(); // string list

        }
    }
}
