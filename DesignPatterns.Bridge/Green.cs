using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class Green : IColor
    {
        public void FillColor()
        {
            Console.WriteLine("Filling in Green Color");
        }
    }
}