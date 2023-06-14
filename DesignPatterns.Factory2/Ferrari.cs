using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory2
{
    public class Ferrari : ICar
    {
        public void Start()
        {
            Console.WriteLine("Ferrari is starting");
        }
    }
}