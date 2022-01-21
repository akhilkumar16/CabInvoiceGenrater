using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;
using CabInvoiceGenrator;

namespace CabInvoiceTest
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenertor invoiceGenertor = null;

        [TestMethod]
        public void GivenDistanceAndTimeShouldTotalFare()
        {
            invoiceGenertor = new InvoiceGenertor(RideType.Normal);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenertor.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
        [TestMethod]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            invoiceGenertor = new InvoiceGenertor(RideType.Normal);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = invoiceGenertor.CalculateFare(rides);
            InvoiceSummary excpectedSummary = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(excpectedSummary, summary);
        }
    }
}