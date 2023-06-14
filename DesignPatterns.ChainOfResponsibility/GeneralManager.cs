using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class GeneralManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 10000)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchase.RequestNumber);
            }
            else 
            {
                // eenja payane zanjireh hast
                Console.WriteLine("Purchasing request #{0} requires an executive meeting!",
                    purchase.RequestNumber);
            }
        }
    }
}