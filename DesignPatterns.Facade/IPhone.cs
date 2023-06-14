using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade
{
    public class IPhone : IMobileShop
    {
        public void ModelNo()
        {
            Console.WriteLine("IPhone 12");
        }

        public void Price()
        {
            Console.WriteLine("800$");
        }
    }
}