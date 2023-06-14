using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade
{
    public class Samsung : IMobileShop
    {
        public void ModelNo()
        {
            Console.WriteLine("Samsung S20");
        }

        public void Price()
        {
            Console.WriteLine("580$");
        }
    }
}