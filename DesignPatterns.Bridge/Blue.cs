using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class Blue : IColor
    {
        public void FillColor()
        {
            Console.WriteLine("Filling in Blue Color");
        }
    }
}