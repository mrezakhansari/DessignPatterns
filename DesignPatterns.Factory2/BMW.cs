using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory2
{
    public class BMW : ICar
    {
        public void Start()
        {
            Console.WriteLine("BMW is starting");
        }
    }
}