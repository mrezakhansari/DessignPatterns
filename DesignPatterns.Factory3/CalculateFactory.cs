using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Factory3
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate calculate = null;
            if (type.ToLower() == "add")
            {
                calculate = new Add();
            }
            else if (type.ToLower() == "divide")
            {
                calculate = new Divide();
            }
            else if (type.ToLower() == "subtract")
            {
                calculate = new Subtract();
            }
            else if (type.ToLower() == "multiply")
            {
                calculate = new Multiply();
            }
            return calculate;
        }
    }
}