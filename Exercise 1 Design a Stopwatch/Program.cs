using System;

namespace Exercise_1_Design_a_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(stopwatch.Stop());
        }
    }
}
