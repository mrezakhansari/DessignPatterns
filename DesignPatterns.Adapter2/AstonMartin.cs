using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter2ClassLibrary
{
    public class AstonMartin : Movable
    {
        //returns speed in MPH
        public double GetSpeed()
        {
            return 220;
        }
    }
}