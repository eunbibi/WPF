using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize array of invoices
            var invoices = new[] {
                new Invoice(87, "Electric Sander", 7, 57.98M),
                new Invoice(24, "Power Saw", 18, 99.99M),
                new Invoice(7, "Sledge Hammer", 11, 21.50M),
                new Invoice(77, "Hammer", 76, 11.99M),
                new Invoice(39, "Lawn Mower", 3, 79.50M),
                new Invoice(68, "Screw Driver", 106, 6.99M),
                new Invoice(56, "Jig saw", 21, 11.00M)
            };
            Console.WriteLine("----------------------------------------------------------------");

            // Display all invoices
            Console.WriteLine("Original array:                                                 l");
            foreach (var element in invoices)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("----------------------------------------------------------------");

            //a) Calculated column InvoiceTotal
            var invoiceTotal =
               from val in invoices
                   //let value = val.Quantity * Convert.ToDecimal(val.Price)
               let value = val.Quantity * val.Price
               orderby value ascending
               select new { Part_Description = val.PartDescription, InvoiceTotal = value};

            // Print the results PartDecription and Price
            Console.Write("\nInvoice total = Quanitity*Price");
            foreach (var element in invoiceTotal)
            {
                Console.Write($"\n {element}");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------");

            //b) PartDecription of the part who has highest Quantity:
            var sortedPriceAndDesc =
               from val in invoices
               where val.Quantity >= 100
               select new { Qty = val.Quantity, Part_Description = val.PartDescription };

            Console.Write("\nPartDecription of the part who has highest Quantity:");
            foreach (var element in sortedPriceAndDesc)
            {
                Console.Write($"\n {element}");
            }
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------");

            //c)Display average Price of the parts
            Console.WriteLine("\nAverage Price of the parts");
            var sortedByPrice =
               (from v in invoices select v.Price).Average();
            Console.WriteLine(sortedByPrice);
            Console.WriteLine();

            // Use LINQ to sort the Invoice items by PartDescription
            var sortAndFilter =
               from value in invoices
               orderby value.PartDescription descending
               select value;

            Console.WriteLine("----------------------------------------------------------------");

        }
    }
}
