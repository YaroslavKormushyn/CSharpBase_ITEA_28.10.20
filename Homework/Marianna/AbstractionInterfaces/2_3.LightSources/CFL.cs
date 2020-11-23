using System;
using System.Collections.Generic;
using System.Text;

namespace _2_3.LightSources
{
    class CFL : ILightSource
    {
        public CFL(double area, double powerUsage)
        {
            AreaSize = area;
            PowerUsage = powerUsage;
        }
        public void TurnOn()
        {
            Console.WriteLine("The CFL bulb is turned on!");
        }
        public void TurnOff()
        {
            Console.WriteLine("The CFL bulb is turned off!");
        }
        public double AreaSize { get; set; }
        public double PowerUsage { get; set; }
    }
}
