using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory2
{
    public class FactoryProvider
    {
        public static FurnitureAbstractFactory GetFactory(FurnitureType furnitureType)
        {
            FurnitureAbstractFactory furnitureAbstractFactory = null;
            switch (furnitureType)
            {
                case FurnitureType.ART:
                    furnitureAbstractFactory = new ArtFurnitureFactory();
                    break;
                case FurnitureType.VICTORIAN:
                    furnitureAbstractFactory = new VictorianFurnitureFactory();
                    break;
            }
            return furnitureAbstractFactory;
        }
    }
}