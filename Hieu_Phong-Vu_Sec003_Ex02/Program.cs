using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hieu_Phong_Vu_Sec003_Ex02
{
    class Program
    {
        //Testing Exercise 2
        static void Main(string[] args)
        {
            Invoice[] invoices = new Invoice[] { 
                new Invoice(87,"Electric Sander",7,57.98m),
                new Invoice(24,"Power Saw",18,99.99m),
                new Invoice(7,"Sledge Hammer",11,21.50m),
                new Invoice(77,"Hammer",76,11.99m),
                new Invoice(39,"Lawn Mower",3,79.50m),
                new Invoice(68,"Screw Driver",106,6.99m),
                new Invoice(56,"Jig Saw",21,11.00m)
            };

            Console.WriteLine($"Part Number\tPart Desc\tQuantity\tPrice");
            foreach(var invoice in invoices)
            {
                Console.WriteLine($"{invoice.partNumber,-16}{invoice.partDesc,-19}{invoice.quantity,-10}{invoice.price,8}");
            }

            var invoiceTotals = from invoice in invoices
                                let invoiceTotal = invoice.quantity * invoice.price
                                orderby invoiceTotal ascending
                                select invoiceTotal;
            Console.WriteLine("\nInvoice Total:");
            foreach(var invoiceTotal in invoiceTotals)
            {
                Console.WriteLine(invoiceTotal);
            }

            var descHighestQuanity = from invoice in invoices
                                     where invoice.quantity == invoices.Max(x => x.quantity)
                                     select invoice.partDesc;
            
            Console.WriteLine("\nPart description of part with highest Quantity: "+descHighestQuanity.FirstOrDefault());

            var prices = from invoice in invoices select invoice.price;
            Console.WriteLine("\nAverage price of parts: "+Math.Round(prices.Average(),2));
        }
    }
}
