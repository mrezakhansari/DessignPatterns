using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter2ClassLibrary
{
    public class McLaren : Movable
    {
        //returns speed in MPH
        public double GetSpeed()
        {
            return 241;
        }
    }
}