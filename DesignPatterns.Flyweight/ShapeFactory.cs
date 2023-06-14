using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();

        public static IShape GetShape(string shapeType)
        {
            IShape shape = null;
            if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if (shapeMap.TryGetValue("circle",out shape))
                {
                    shape = shapeMap["circle"];
                }
                else
                {
                    shape = new Circle();
                    shapeMap.Add("circle", shape);
                    Console.WriteLine("Create circle object without any color");
                }
            }
            return shape;
        }

        public static int GetCount()
        {
            return shapeMap.Count;  
        }

    }
}