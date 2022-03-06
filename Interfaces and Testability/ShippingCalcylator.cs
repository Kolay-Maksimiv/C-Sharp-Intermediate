using System;

namespace Interfaces_and_Testability
{
    public interface IShippingCalcylator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalcylator: IShippingCalcylator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}