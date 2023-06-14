using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Command
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is on");
        }
        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }
        public void SetCD()
        {
            Console.WriteLine("Stereo is set for CD input");
        }
        public void SetDVD()
        {
            Console.WriteLine("Stereo is set for DVD input");
        }
        public void SetRadio()
        {
            Console.WriteLine("Stereo is set for radio");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine($"Stereo volume is set to {volume}");
        }
    }
}