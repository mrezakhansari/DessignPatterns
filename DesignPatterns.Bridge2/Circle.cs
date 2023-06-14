using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Bridge2
{
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
            color.FillColor();
        }
    }
}