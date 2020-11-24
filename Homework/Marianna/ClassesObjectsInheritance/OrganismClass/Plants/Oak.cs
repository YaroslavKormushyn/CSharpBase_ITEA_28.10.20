using System;
using System.Collections.Generic;
using System.Text;

namespace OrganismClass
{
    class Oak : Plant
    {

        public override void Grow(int period)
        {
            Console.WriteLine("Oak is growing for {0} years.", period);
        }

        public override string ToString()
        {
            return ("an Oak");
        }
    }
}
