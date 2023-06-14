using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory2
{
    public class CarFactory
    {
        public ICar GetCar(string type)
        {
            ICar car = null;
            if (type.ToLower() == "bmw")
            {
                car = new BMW();
            }
            else if (type.ToLower() == "toyota")
            {
                car = new Toyota();
            }
            else if (type.ToLower() == "ferrari")
            {
                car = new Ferrari();
            }
            else
            {
                throw new Exception("Not valid type");
            }
            return car;
        }
    }
}