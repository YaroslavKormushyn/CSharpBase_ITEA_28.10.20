using System;
using System.Collections.Generic;
using System.Text;

namespace OrganismClass
{
    abstract class Plant : Organism
    {
        public override void Grow(int period)
        {
            Console.WriteLine("Plant is growing!");
        }

        public sealed override void Photosynthesize()
        {
            Console.WriteLine("Doing Photosynthesis!!");
        }
    }
}
