using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class LightDialog : IDialog
    {
        public void ShowDialog()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("White Dialog");
        }
    }
}