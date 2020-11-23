using System;
using System.Collections.Generic;
using System.Text;

namespace _2_3.LightSources
{
    class Halogen : ILightSource
    {
        public Halogen(double area, double powerUsage)
        {
            AreaSize = area;
            PowerUsage = powerUsage;
        }
        public void TurnOn()
        {
            Console.WriteLine("The Halogen bulb is turned on!");
        }
        public void TurnOff()
        {
            Console.WriteLine("The Halogen bulb is turned off!");
        }

        public double AreaSize { get; set; }
        public double PowerUsage { get; set; }
    }
}
