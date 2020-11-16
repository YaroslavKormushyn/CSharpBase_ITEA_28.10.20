using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClass
{
     abstract class ThreeDimensionalShape : Shape
    {
        public ThreeDimensionalShape(double a) : base(a)
        {
        }
        public override abstract double Area { get; }
        public abstract double Volume { get; }
        public override string ToString()
        {
            return string.Format("It is a three-dimensional shape!");
        }
    }
}