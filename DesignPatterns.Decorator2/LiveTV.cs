using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator2
{
    public class LiveTV : FlightSeatDecorator
    {
        public LiveTV(IFlightSeat flightSeat) : base(flightSeat)
        {

        }
        public override string GetFacilities() => this.flightSeat.GetFacilities() + "\n LiveTV";
        public override double GetPrice() => this.flightSeat.GetPrice() + 0.6;
    }
}