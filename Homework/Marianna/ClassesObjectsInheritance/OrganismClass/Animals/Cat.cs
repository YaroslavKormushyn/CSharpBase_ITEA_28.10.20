using System;
using System.Collections.Generic;
using System.Text;

namespace OrganismClass
{
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says Meooow!");
        }

        public override string ToString()
        {
            return ("a Cat");
        }

        public override void Grow(int period)
        {
            Console.WriteLine("Cat is growing for {0} years.", period);
        }
    }
}
