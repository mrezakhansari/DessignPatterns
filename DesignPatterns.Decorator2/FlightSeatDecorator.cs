using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Decorator2
{
    public abstract class FlightSeatDecorator : IFlightSeat
    {
        protected IFlightSeat flightSeat;

        public FlightSeatDecorator(IFlightSeat flightSeat)
        {
            this.flightSeat = flightSeat;
        }

        public abstract string GetFacilities();

        public abstract double GetPrice();
    }
}