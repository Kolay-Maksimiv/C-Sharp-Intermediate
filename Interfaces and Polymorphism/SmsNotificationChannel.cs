using System;

namespace Interfaces_and_Polymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Massage massage)
        {
            Console.WriteLine("Sending SMS ...");
        }
    }
}