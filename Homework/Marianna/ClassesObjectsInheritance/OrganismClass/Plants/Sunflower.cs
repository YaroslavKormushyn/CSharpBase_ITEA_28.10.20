using System;
using System.Collections.Generic;
using System.Text;

namespace OrganismClass
{
    class Sunflower : Plant
    {
        public override void Grow(int period)
        {
            Console.WriteLine("Sunflower is growing for {0} years.", period);
        }

        public override string ToString()
        {
            return ("a Sunflower ");
        }
    }
}
