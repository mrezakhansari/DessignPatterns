using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {

        }
        public override string Description => beverage.Description + ", Whip";
        public override double Cost() => beverage.Cost() + 0.10;
    }
}