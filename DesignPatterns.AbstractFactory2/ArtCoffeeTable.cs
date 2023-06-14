using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory2
{
    public class ArtCoffeeTable : ICoffeeTable
    {
        public void DrinkCoffee()
        {
            Console.WriteLine("DrinkCoffee: ArtCoffeeTable");
        }
    }
}