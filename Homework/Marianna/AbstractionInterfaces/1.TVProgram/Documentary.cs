using System;
using System.Collections.Generic;
using System.Text;

namespace _1.TVProgram
{
    class Documentary : Science
    {
        public Documentary(string nameOfProgram, int ratingOfProgram, DateTime startOfProgram, DateTime endOfProgram) : base(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram)
        {

        }

        internal static object Create(string nameOfProgram, int ratingOfProgram, DateTime startOfProgram, DateTime endOfProgram)
        {
            return new Documentary(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram);
        }
    }
}