using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite
{
    public class MenuItem : IMenuComponent
    {
        private readonly string name;
        private readonly string description;
        private readonly double price;
        private readonly bool isVegetarian;

        public string Name => name;

        public string Description => description;

        public double Price => price;

        public bool IsVegetarian => isVegetarian;

        public MenuItem(string name, string description, bool vegetarian,double price)
        {
            this.name = name;
            this.description = description; 
            this.price = price; 
            this.isVegetarian = vegetarian;
        }

        public string ShowIfVeg(bool isVegetarian)
        {
            if (isVegetarian)
            {
                return "V";
            }
            return "";
        }


        public string Show()
        {
            return "\t" + Name +
                "\t" + ShowIfVeg(IsVegetarian) +
                "\t" + Price + "\t--" + description + "\n";
        }
    }
}