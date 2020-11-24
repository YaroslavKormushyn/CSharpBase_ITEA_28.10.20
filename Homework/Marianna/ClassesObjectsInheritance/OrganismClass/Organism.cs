using System;
using System.Collections.Generic;
using System.Text;

namespace OrganismClass
{
    abstract class Organism
    {
        public abstract void Grow(int period);

        public virtual void Photosynthesize()
        {

        }
        public abstract override string ToString();
    }
}
