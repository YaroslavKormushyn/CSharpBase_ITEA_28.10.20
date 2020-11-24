using System;
using System.Collections.Generic;
using System.Text;

namespace OrganismClass
{
    abstract class Animal : Organism
    {
        public abstract void MakeSound();

        public override void Grow(int period)
        {
            Console.WriteLine("Animal is growing!");
        }

        public override string ToString()
        {
            return ("It is an Animal!");
        }
    }
}
