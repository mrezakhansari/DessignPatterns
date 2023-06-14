using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public class ConstructionEngineer
    {
        private HouseBuilder houseBuilder;
        public ConstructionEngineer(HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }
        public House ConstructHouse()
        {
            houseBuilder.BuildFoundation();
            houseBuilder.BuildStructure();
            houseBuilder.BuildRoof();
            houseBuilder.PaintHouse();
            houseBuilder.FurnishHouse();
            return houseBuilder.GetHouse();
        }
    }
}