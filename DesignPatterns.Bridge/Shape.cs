using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Bridge
{
    public abstract class Shape
    {
        protected IColor color;

        public Shape(IColor color)
        {
            this.color = color;
        }

        public IColor IColor
        {
            get => default;
            set
            {
            }
        }

        public abstract void Draw();
    }
}