using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.description = "Decaf";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}