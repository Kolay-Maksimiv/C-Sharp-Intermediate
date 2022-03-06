using System;

namespace Interfaces_and_Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalcylator _shippingCalcylator;

        public OrderProcessor(IShippingCalcylator shippingCalcylator)
        {
            _shippingCalcylator = shippingCalcylator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalcylator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };

        }
    }
}
