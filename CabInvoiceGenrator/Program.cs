using CabInvoiceGenerator;
using System;

namespace CabInvoiceGenrator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator \n ");
            InvoiceGenertor invoiceGenerator = new InvoiceGenertor(RideType.Normal);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");

            Ride[] rides = { new Ride(2.0, 5), new Ride(1.0, 1) };
            invoiceGenerator.AddRides("name", rides);

            invoiceGenerator.GetInvoiceSummary("name");
        }
    }
}
