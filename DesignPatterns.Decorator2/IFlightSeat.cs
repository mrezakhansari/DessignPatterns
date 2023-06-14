using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator2
{
    public interface IFlightSeat
    {
        string GetFacilities();
        double GetPrice();
    }
}