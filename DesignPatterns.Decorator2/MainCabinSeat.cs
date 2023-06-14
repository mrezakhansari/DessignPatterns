using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator2
{
    public class MainCabinSeat : IFlightSeat
    {
        public string GetFacilities() => "Free Food";

        public double GetPrice() => 6400.0;
    }
}