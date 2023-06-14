using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade
{
    public class BlackBerry : IMobileShop
    {
        public void ModelNo()
        {
            Console.WriteLine("BlackBerry Key2 LE");
        }

        public void Price()
        {
            Console.WriteLine("585$");
        }
    }
}