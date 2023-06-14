using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ShapeFactory
    {
        public IShape GetShape(string type)
        {
            if (type.ToLower() == "rectangle")
            {
                return new Rectangle();
            }
            else if (type.ToLower() == "square")
            {
                return new Square();
            }
            else if (type.ToLower() == "circle")
            {
                return new Circle();
            }
            return null;
        }
    }
}
