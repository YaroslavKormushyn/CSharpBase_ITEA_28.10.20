using System;

namespace ShapeClass
{
    class Program
    {
        static void Main()
        {
            Shape[] shape = new Shape[6];
            shape[0] = new Square(5);
            shape[1] = new Sphere(2);
            shape[2] = new Cube(3);
            shape[3] = new Circle(8);
            shape[4] = new Triangle(3,10);
            shape[5] = new Pyramid(6,4,6);
           double sumAreaTwoD = 0;
            double sumAreaThreeD = 0;
            double sumVolumeThreeD = 0;
            foreach (Shape s in shape)
            {
                if (s is TwoDimensionalShape)
                {
                    Console.WriteLine(s);
                    Console.WriteLine("The Area is: " + s.Area);
                    sumAreaTwoD += s.Area;
                }
                else
                {
                    ThreeDimensionalShape threeDShape = (ThreeDimensionalShape)s; 
                    Console.WriteLine(s);
                    Console.WriteLine("The Area is: " + s.Area);
                    Console.WriteLine("The Volume is: " + threeDShape.Volume);
                    sumAreaThreeD += s.Area;
                    sumVolumeThreeD += threeDShape.Volume;
                }
                
            }
            Console.WriteLine("Sum of Area:" +( sumAreaTwoD + sumAreaThreeD));
            Console.WriteLine("Sum of Volume:" + sumVolumeThreeD);
        }
    }
}
