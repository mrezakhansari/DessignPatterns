using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public class PrefabricatedHouseBuilder : HouseBuilder
    {
        private House house;
        public PrefabricatedHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildFoundation()
        {
            house.Foundation = "Wood, laminate and PVC flooring";
            Console.WriteLine("PrefabricatedHouseBuilder: Foundation complete...");
        }

        public void BuildRoof()
        {
            house.Roof = "Roofing sheets";
            Console.WriteLine("PrefabricatedHouseBuilder: Roof complete...");
        }

        public void BuildStructure()
        {
            house.Structure = "Structural steels and wooden wall panels";
            Console.WriteLine("PrefabricatedHouseBuilder: Structure complete...");
        }

        public void FurnishHouse()
        {
            house.Furnished = true;
            Console.WriteLine("PrefabricatedHouseBuilder: Furnishing complete ...");
        }

        public void PaintHouse()
        {
            house.Painted = false;
            Console.WriteLine("PrefabricatedHouseBuilder: Painting not required ...");
        }

        public House GetHouse()
        {
            Console.WriteLine("PrefabricatedHouseBuilder: Prefabricated house complete ...");
            return house;
        }
    }
}