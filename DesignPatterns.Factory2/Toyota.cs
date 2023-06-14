using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory2
{
    public class Toyota : ICar
    {
        public void Start()
        {
            Console.WriteLine("Toyota is starting");
        }
    }
}