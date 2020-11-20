using System;
using System.Collections.Generic;
using System.Text;

namespace _1.TVProgram
{
    class Cartoon : Entertainment
    {
        public Cartoon(string nameOfProgram, int ratingOfProgram, DateTime startOfProgram, DateTime endOfProgram) : base(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram)
        {

        }

        internal static object Create(string nameOfProgram, int ratingOfProgram, DateTime startOfProgram, DateTime endOfProgram)
        {
            return new Cartoon(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram);
        }
    }
}
