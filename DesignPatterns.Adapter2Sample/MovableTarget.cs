using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter2Sample
{
    public interface MovableTarget
    {
        // returns speed in KMPH
        double GetSpeed();
    }
}