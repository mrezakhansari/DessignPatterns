using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Bridge2
{
    public abstract class Shape
    {
        protected IColor color;
        public Shape(IColor color)
        {
            this.color = color;
        }
        public abstract void Draw();
    }
}