using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGenerator
{
    [TestClass]
    public class CabInvoiceTestGenerator
    {

        [TestMethod]
        public void GivenDistanceTimeToCalculateFare()
        { 
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();

            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double excepted=25;
            Assert.AreEqual(excepted, fare);
        }
        [TestMethod]
        public void GivenMultipleRideInvoice()
        { 
            InvoiceGenerator invoiceGenerator1 = new InvoiceGenerator();
            Ride[] rides = { new Ride(2.0,5), new Ride(0.1,1)};
        }
    }
}
