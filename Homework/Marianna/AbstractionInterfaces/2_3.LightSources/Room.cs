using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_3.LightSources
{
    class Room
    {
        public Room(List<ILightSource> arrayOfLightSources, double maxArea, double maxUsageOfPower)
        {
            Sources = arrayOfLightSources;
            MaxAreaSize = maxArea;
            MaxPowerUsage = maxUsageOfPower;
        }

        public List<ILightSource> Sources { get; set; }
        public double MaxAreaSize { get; set; }
        public double MaxPowerUsage { get; set; }

        public void CheckParameters(List<ILightSource> arrayOfLightSources)
        {
            double sumArea = 0;
            double sumPower = 0;
            IEnumerable<ILightSource> query = arrayOfLightSources.OrderBy(program => program.AreaSize);
            foreach (ILightSource program in query)
            {
                sumArea += program.AreaSize;
            }
            Console.WriteLine("Sum of Illumination area size of all light sources present in the room: {0}. ", sumArea);

            IEnumerable<ILightSource> query1 = arrayOfLightSources.OrderBy(program1 => program1.PowerUsage);
            foreach (ILightSource program1 in query1)
            {
                sumPower += program1.PowerUsage;
            }
            Console.WriteLine("Sum of power usage of all light sources present in the room: {0}. ", sumPower);
            if ((sumArea < 0.9 * MaxAreaSize) || (sumArea > MaxAreaSize) || (sumPower > MaxPowerUsage))
            {
                Console.WriteLine("Entered parameters of all light sources does not match the parameters of the following room!");
            }
            else
            //((sumArea > 0.9 * MaxAreaSize) && (sumArea <= MaxAreaSize)&& (sumPower < MaxPowerUsage))
            {
                Console.WriteLine("Illumination area and Power usage of all light sources match the parameters of the following room!");
            }
        }

        public void AddLightSources(List<ILightSource> arrayOfLightSources, int index)
        {
            Console.WriteLine("Please enter the digit in the range 0-3:(0-to add Halogen LightSource ; 1-to add Incandescent LightSource; 2-to add CFL LightSource; 1-to add LED LightSource)");
            int caseSwitch = Int32.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 0:
                    {
                        arrayOfLightSources.Insert(index, new Halogen(34, 455));
                        break;
                    }
                case 1:
                    {
                        arrayOfLightSources.Insert(index, new Incandescent(34, 455));
                        break;
                    }
                case 2:
                    {
                        arrayOfLightSources.Insert(index, new CFL(364, 4655));
                        break;
                    }
                case 3:
                    {
                        arrayOfLightSources.Insert(index, new LED(364, 4575));
                        break;
                    }
                default:
                    Console.WriteLine("The wrong input!");
                    break;
            }
            Console.WriteLine("Added");
        }
        public void RemoveLightSources(List<ILightSource> arrayOfLightSources, int index)
        {
            arrayOfLightSources.RemoveAt(index);
            Console.WriteLine("Removed");
        }
    }
}


