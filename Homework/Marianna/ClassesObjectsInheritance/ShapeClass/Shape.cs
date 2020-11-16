using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClass
{
   abstract class Shape
    {
        public Shape(double sideSize)
        {
            Side = sideSize;
        }
        public double Side { get; set; }
        public abstract double Area { get; }
        public abstract override string ToString(); 

    }
}
