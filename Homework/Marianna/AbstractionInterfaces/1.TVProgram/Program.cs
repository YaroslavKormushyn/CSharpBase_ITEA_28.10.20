using System;
using System.Collections.Generic;
using System.Linq;
namespace _1.TVProgram
{
    class Program
    {
        static void Main()
        {
            int number;
            int caseSwitch;
            string nameOfProgram;
            int ratingOfProgram;
            DateTime startOfProgram;
            DateTime endOfProgram;
            Console.WriteLine("Please enter the number of Programs which you want to add to array:");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("The wrong input! Please enter the valid input!");
            }
            TvProgram[] programs = new TvProgram[number];
            Console.WriteLine("Please enter the digit in the range 0-3:(0-to add Cartoon; 1-to add News; 2-to add Show; 3-to add Documentary)");
            while ((!int.TryParse(Console.ReadLine(), out caseSwitch)) || caseSwitch > 3 || caseSwitch < 0)
            {
                Console.WriteLine("The wrong input! Please enter the valid input!");
            }
            Console.Write("Please enter the name of Program:");
            nameOfProgram = Console.ReadLine();
            Console.WriteLine("Please enter the rating of Program:");
            while (!int.TryParse(Console.ReadLine(), out ratingOfProgram))
            {
                Console.Write("The wrong input! Please enter the valid input!");
            }
            Console.WriteLine("Please enter the start (DateTime format month/day/year hours:minutes:seconds AM/PM) of Program:");
            while (!DateTime.TryParse(Console.ReadLine(), out startOfProgram))
            {
                Console.Write("The wrong input! Please enter the valid input!");
            }
            Console.Write("Please enter the start (DateTime format month / day / year hours: minutes:seconds AM / PM) of Program:");
            while (!DateTime.TryParse(Console.ReadLine(), out endOfProgram))
            {
                Console.WriteLine("The wrong input! Please enter the valid input!");
            }
            for (int i = 0; i < number; i++)
            {
                switch (caseSwitch)
                {
                    case 0:
                        {
                            programs[i] = new Cartoon(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram);
                            break;
                        }
                    case 1:
                        {
                            programs[i] = new News(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram);
                            break;
                        }
                    case 2:
                        {
                            programs[i] = new Show(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram);
                            break;
                        }
                    case 3:
                        {
                            programs[i] = new Documentary(nameOfProgram, ratingOfProgram, startOfProgram, endOfProgram);
                            break;
                        }
                    default:
                        Console.WriteLine("The wrong input!");
                        break;
                }
            }
            /*
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
            */
            Console.WriteLine("Descending order by Rating column:");
            IEnumerable<TvProgram> query = programs.OrderByDescending(program => program.Rating);
            foreach (TvProgram program in query)
            {
                Console.WriteLine("The name of TvProgram: {0}. Rating:  {1}  ", program.Name, program.Rating);
            }
            Console.WriteLine();

            Console.WriteLine("Output science programs which air after (2020, 11, 20) point in time:");
            var greaterThanThis = new DateTime(2020, 11, 20);
            IEnumerable<TvProgram> query1 = programs.Where((program) => program.Start > greaterThanThis && program is Science);

            foreach (TvProgram program in query1)
            {
                Console.WriteLine("The name of TvProgram: {0} the air time: from {1} to  {2} ", program.Name, program.Start, program.End);
            }
            Console.WriteLine();

            Console.WriteLine("Output programs which are longer than two hours:");
            TimeSpan aTwo = new System.TimeSpan(2, 0, 0);
            IEnumerable<TvProgram> query2 = programs.Where((program) => program.End.Subtract(program.Start) > aTwo);
            foreach (TvProgram program in query2)
            {
                Console.WriteLine("The name of TvProgram: {0} the air time: from {1} to  {2}  TimeSpan:{3} ", program.Name, program.Start, program.End, program.End.Subtract(program.Start));
            }
            /*
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
           */
        }
    }
}


