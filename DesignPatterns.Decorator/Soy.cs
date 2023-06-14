using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {

        }
        public override string Description => beverage.Description + ", Soy";
        public override double Cost() => beverage.Cost() + 0.20;
    }
}