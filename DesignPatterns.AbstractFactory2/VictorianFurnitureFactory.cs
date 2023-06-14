using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory2
{
    public class VictorianFurnitureFactory : FurnitureAbstractFactory
    {
        public IChair CreateChair()
        {
            IChair victorianChair = new VictorianChair();
            return victorianChair;
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            ICoffeeTable victorianCoffeeTable = new VictorianCoffeeTable();
            return victorianCoffeeTable;
        }

        public ISofa CreateSofa()
        {
            ISofa victorianSofa = new VictorianSofa();
            return victorianSofa;
        }
    }
}