using System;

namespace OrganismClass
{
    class Program
    {
        private static int p;

        static void Main()
        {
            Organism[] organisms = new Organism[6];
            organisms[0] = new Sunflower();
            organisms[1] = new Oak();
            organisms[2] = new Cat();
            organisms[3] = new Elephant();
            organisms[4] = new Sunflower();
            organisms[5] = new Cat();
            foreach (Organism s in organisms)
            {
                Console.Write("Enter time period(years) for {0}: ", s);
                if (!int.TryParse(Console.ReadLine(), result: out p))
                {
                    Console.WriteLine("The wrong input! ");
                    return;
                };
                s.Grow(p);
            }
            foreach (Organism s in organisms)
            {
                if (s is Plant)
                {
                    Console.Write(s);
                    s.Photosynthesize();
                }
                else
                {
                    Animal animal = (Animal)s;
                    animal.MakeSound();
                }
            }
        }
    }
}
