using System;

namespace _1.TVProgram
{
    abstract class TvProgram
    {
        public TvProgram(string nameOfProgram, int ratingOfProgram, DateTime startOfProgram, DateTime endOfProgram)
        {
            {
                Name = nameOfProgram;
                Rating = ratingOfProgram;
                Start = startOfProgram;
                End = endOfProgram;
            }
        }
        public string Name { get; set; }
        public int Rating { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
