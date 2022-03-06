using System;

namespace Interfaces_and_Testability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalcylator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };

            orderProcessor.Process(order);
        }
    }
}
