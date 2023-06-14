using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class PurchaseOrder
    {
        public int RequestNumber { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }

        public PurchaseOrder(int requestNumber,double amount,double price,string name) 
        {
            RequestNumber = requestNumber;
            Amount = amount;
            Price = price;
            Name = name;

            Console.WriteLine("Purchase request for " + name + " (" + amount + " for $"
                + price.ToString() + ") has been submitted.");
        }
    }
}