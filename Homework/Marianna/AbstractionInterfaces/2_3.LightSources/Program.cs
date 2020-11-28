using System;
using System.Collections.Generic;

namespace _2_3.LightSources
{
    class Program
    {
        static void Main()
        {
            List<ILightSource> list = new List<ILightSource>() {
            new Halogen( 34, 455),
            new Incandescent(34, 455),
            new CFL(364, 4655),
            new LED(364, 4575),
            new CFL(364, 465),
            new LED(364, 475)};
            Room room1 = new Room(list, 1524, 11160);

            foreach (ILightSource k in list)
            {
                Console.WriteLine(": {0},{1}", k.AreaSize, k.PowerUsage);
            }
            foreach (ILightSource k in list)
            {
                k.TurnOn();
            }
            foreach (ILightSource k in list)
            {
                k.TurnOff();
            }
            room1.AddLightSources(list, 3);
            foreach (ILightSource k in list)
            {
                Console.WriteLine(": {0},{1}", k.AreaSize, k.PowerUsage);
            }
            foreach (ILightSource k in list)
            {
                k.TurnOn();
            }
            room1.RemoveLightSources(list, 4);
            foreach (ILightSource k in list)
            {
                Console.WriteLine(": {0},{1}", k.AreaSize, k.PowerUsage);
            }
            foreach (ILightSource k in list)
            {
                k.TurnOff();
            }
            room1.CheckParameters(list);
        }
    }
}
