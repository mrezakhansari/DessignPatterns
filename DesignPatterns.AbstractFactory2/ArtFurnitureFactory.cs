using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory2
{
    public class ArtFurnitureFactory : FurnitureAbstractFactory
    {
        public IChair CreateChair()
        {
            IChair artChair = new ArtChair();
            return artChair;
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            ICoffeeTable artCoffeeTable = new ArtCoffeeTable();
            return artCoffeeTable;
        }

        public ISofa CreateSofa()
        {
            ISofa artSofa = new ArtSofa();
            return artSofa;
        }
    }
}