using System;
using System.Collections.Generic;
using System.Text;

namespace _1.TVProgram
{
    class News : Science
    {
        public News(string nameOfProgram, int ratingOfProgram, DateTime startOfProgram, DateTime endOfProgram) : base(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram)
        {

        }

        internal static object Create(string nameOfProgram, int ratingOfProgram, DateTime startOfProgram, DateTime endOfProgram)
        {
            return new News(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram);
        }
    }
}
