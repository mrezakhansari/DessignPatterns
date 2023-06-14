using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public class ConcreteHouseBuilder : HouseBuilder
    {
        private House house;
        public ConcreteHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildFoundation()
        {
            house.Foundation = "Concrete, brick and stone";
            Console.WriteLine("ConcreteHouseBuilder: Foundation complete...");
        }

        public void BuildRoof()
        {
            house.Roof = "Concrete and reinforced steel";
            Console.WriteLine("ConcreteHouseBuilder: Roof complete...");
        }

        public void BuildStructure()
        {
            house.Structure = "Concrete, mortar, brick and reinforced steel";
            Console.WriteLine("ConcreteHouseBuilder: Structure complete...");
        }

        public void FurnishHouse()
        {
            house.Furnished = true;
            Console.WriteLine("ConcreteHouseBuilder: Furnishing complete ...");
        }

        public void PaintHouse()
        {
            house.Painted = true;
            Console.WriteLine("ConcreteHouseBuilder: Painting complete ...");
        }

        public House GetHouse()
        {
            Console.WriteLine("ConcreteHouseBuilder: Concrete house complete ...");
            return house;
        }
    }
}