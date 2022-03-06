using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Interfaces_and_Testability.Testability
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyeShipped_ThrowsAnAxception()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalcylator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShiomentPropretyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalcylator());
            var order = new Order();
            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalcylator : IShippingCalcylator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
