using System;
using System.Collections.Generic;
using System.Text;

namespace _1.TVProgram
{
    class Show : Entertainment
    {
        public Show(string nameOfProgram, int ratingOfProgram, DateTime startOfProgram, DateTime endOfProgram) : base(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram)
        {

        }

        internal static object Create(string nameOfProgram, int ratingOfProgram, DateTime startOfProgram, DateTime endOfProgram)
        {
            return new Show(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram);
        }
    }
}
