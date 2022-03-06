using System;

namespace Interfaces_and_Polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        public void Send(Massage massage)
        {
            Console.WriteLine("Sending mail...");
        }
    }
}