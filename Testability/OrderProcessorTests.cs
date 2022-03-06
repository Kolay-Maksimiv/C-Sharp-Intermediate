using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testability
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION

        [TestMethod]
        public void Process_OrderIsAlreadyeShipped_ThrowsAnAxception()
        {
            var orderProcessor = new OrderProcessor();
        }

        public class FakeShippingCalcylator : IShippingCalcylator
        {

        }
    }
}
