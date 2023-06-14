using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
            
        }
        public override string Description => beverage.Description + ", Mocha";
        public override double Cost() => beverage.Cost() + 0.20;
    }
}