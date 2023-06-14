using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory2
{
    public class VictorianCoffeeTable : ICoffeeTable
    {
        public void DrinkCoffee()
        {
            Console.WriteLine("DrinkCoffee: VictorianCoffeeTable");
        }
    }
}