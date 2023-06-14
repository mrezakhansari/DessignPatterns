using DesignPatterns.Adapter2ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter2Sample
{
    public class MovableAdapter : MovableTarget
    {
        private Movable luxuryCars;
        public MovableAdapter(Movable luxuryCars)
        {
            this.luxuryCars = luxuryCars;
        }

        // returns speed in KMPH
        public double GetSpeed()
        {
            double mph = luxuryCars.GetSpeed();
            return ConvertMPHtoKPMH(mph);
        }

        private double ConvertMPHtoKPMH(double mph)
        {
            return mph * 1.60934;
        }
    }
}