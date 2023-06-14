using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator2
{
    public class HeadPhone : FlightSeatDecorator
    {
        public HeadPhone(IFlightSeat flightSeat) : base (flightSeat)
        {
            
        }
        public override string GetFacilities() => this.flightSeat.GetFacilities() + "\n HeadPhones";
        public override double GetPrice()=> this.flightSeat.GetPrice() + 0.8;
    }
}