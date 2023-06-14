using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator2
{
    public class WiFi : FlightSeatDecorator
    {
        public WiFi(IFlightSeat flightSeat) : base(flightSeat)
        {

        }
        public override string GetFacilities() => this.flightSeat.GetFacilities() + "\n WiFi";
        public override double GetPrice() => this.flightSeat.GetPrice() + 11.0;
    }
}