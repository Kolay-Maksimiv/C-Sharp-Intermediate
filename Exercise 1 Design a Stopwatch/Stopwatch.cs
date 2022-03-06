using System;

namespace Exercise_1_Design_a_Stopwatch
{
    public class Stopwatch
    {
        public DateTime Seconds { get; private set; }

        public void Start()
        {
            Seconds = DateTime.Now;
        }

        public double Stop()
        {
            var timeSpan = DateTime.Now - Seconds;
            var seconds = timeSpan.TotalSeconds;

            return seconds;
        }

    }
}
