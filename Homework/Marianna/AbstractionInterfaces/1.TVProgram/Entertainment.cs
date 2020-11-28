using System;
using System.Collections.Generic;
using System.Text;

namespace _1.TVProgram
{
    abstract class Entertainment : TvProgram
    {
        public Entertainment(string nameOfProgram, int ratingOfProgram, DateTime startOfProgram, DateTime endOfProgram) : base(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram)
        {

        }
    }
}
