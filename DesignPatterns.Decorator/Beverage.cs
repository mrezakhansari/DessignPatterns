using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string Description { get => description; }
        public abstract double Cost();
    }
}