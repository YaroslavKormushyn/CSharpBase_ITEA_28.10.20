﻿using System;
using System.Linq;
namespace _1.TVProgram
{
    class Program
    {
        static void Main()
        {
            TvProgram[] programs = new TvProgram[10];
            programs[0] = new Cartoon("Frozen", 10, DateTime.Parse("2020, 12, 01, 12:30:01 PM"), DateTime.Parse("2020, 12, 01, 15:50:01 PM"));
            programs[1] = new News("Toronto", 13, DateTime.Parse("2020, 10, 07, 12:20:01 PM"), DateTime.Parse("2020, 01, 27, 13:20:01 PM"));
            programs[2] = new Show("The Ellen DeGeneres Show", 1, DateTime.Parse("2020, 12, 20, 01:20:01 PM"), DateTime.Parse("2020, 12, 20, 03:42:20 PM"));
            programs[3] = new News("BBC", 4, DateTime.Parse("2020, 08, 23, 10:30:01 AM"), DateTime.Parse("2020, 08, 23, 11:30:01 AM"));
            programs[4] = new Show("The Tonight Show Starring Jimmy Fallon", 10, DateTime.Parse("2020, 12, 02, 10:56:01 AM"), DateTime.Parse("2020, 12, 02, 12:56:01 AM"));
            programs[5] = new Documentary("CHERNOBYL HEART documentary", 4, DateTime.Parse("2020, 11, 20, 10:40:01 AM"), DateTime.Parse("2020, 11, 20, 13:00:01 PM"));
            programs[6] = new Documentary("Miss Americana documentary ", 0, DateTime.Parse("2020, 12, 20, 19:50:01 PM"), DateTime.Parse("2020, 12, 20 , 21:50:01 PM"));
            programs[7] = new Cartoon("Mickey Mouse ", 7, DateTime.Parse("2020, 10, 21, 18:40:01 PM"), DateTime.Parse("2020, 10, 21, 18:55:01 PM"));
            programs[8] = new Cartoon("Gravity Falls", 2, DateTime.Parse("2020, 09, 20, 13:30:01 PM"), DateTime.Parse("2020, 09, 20, 15:30:01 PM"));
            programs[9] = new News("The Age of Mankind documentary", 1, DateTime.Parse("2020, 12, 04, 14:30:01 PM"), DateTime.Parse("2020, 12, 04, 18:30:01 PM"));
            Console.WriteLine("Descending order by Rating column:");
            var qry = from p in programs
                      orderby p.Rating descending
                      select p;
            Array.ForEach<TvProgram>(qry.ToArray<TvProgram>(), p => Console.WriteLine("The name of TvProgram: {0}. Rating:  {1}  ", p.Name, p.Rating));
            Console.WriteLine();

            Console.WriteLine("Output science programs which air after (2020, 11, 20) point in time:");
            var greaterThanThis = new DateTime(2020, 11, 20);
            var qry1 = from k in programs
                       where k.Start > greaterThanThis && k is Science
                       select k;
            Array.ForEach<TvProgram>(qry1.ToArray<TvProgram>(), k => Console.WriteLine("The name of TvProgram: {0} the air time: from {1} to  {2} ", k.Name, k.Start, k.End));
            Console.WriteLine();

            Console.WriteLine("Output programs which are longer than two hours:");
            TimeSpan aTwo = new System.TimeSpan(2, 0, 0);
            var qry2 = from n in programs
                       where n.End.Subtract(n.Start) > aTwo
                       select n;
            Array.ForEach<TvProgram>(qry2.ToArray<TvProgram>(), n => Console.WriteLine("The name of TvProgram: {0} the air time: from {1} to  {2}  TimeSpan:{3} ", n.Name, n.Start, n.End, n.End.Subtract(n.Start)));
        }
    }
}


