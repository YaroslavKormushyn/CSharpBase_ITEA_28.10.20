using System;
using System.Collections.Generic;
using System.Text;

namespace OrganismClass
{
    class Elephant : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Elephant says Pawoooo!");
        }

        public override void Grow(int period)
        {  
            Console.WriteLine("Elephant is growing for {0} years." , period);
        }

        public override string ToString()
        {
            return ("an Elephant ");
        }
    }
}
