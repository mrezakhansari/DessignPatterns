using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public interface HouseBuilder
    {
        void BuildFoundation();
        void BuildStructure();
        void BuildRoof();
        void PaintHouse();
        void FurnishHouse();
        House GetHouse();
    }
}