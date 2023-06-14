using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class Circle : IShape
    {
        public string Color { get; set; }
        private int XCor = 10;
        private int YCor = 20;
        private int Radius = 30;

        public void SetColor(string color)
        {
            this.Color = color; 
        }
        public void Draw()
        {
            Console.WriteLine($"Circle: Draw()[Color: {Color}, X Cor: {XCor}, Y Cor: {YCor}, Radius: {Radius}]");
        }
    }
}