using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Adapter2ClassLibrary
{
    // farz bar een hast ke kole class haye Movable, AstonMArtin, McLaren and Bugatti
    // yek library hastand va ma sourcesh ro nadarim
    // dar vaghe een projeh yek class library hast.
    public interface Movable
    {
        //returns speed in MPH
        double GetSpeed();
    }
}