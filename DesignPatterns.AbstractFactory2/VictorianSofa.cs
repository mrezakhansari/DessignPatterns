using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory2
{
    public class VictorianSofa : ISofa
    {
        public void SitOn()
        {
            Console.WriteLine("SitOn: VictorianSofa");
        }
    }
}