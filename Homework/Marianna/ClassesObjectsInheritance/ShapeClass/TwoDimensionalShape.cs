using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClass
{
  abstract class TwoDimensionalShape: Shape
    {
        public TwoDimensionalShape(double a): base(a)
        {

        }
        public override abstract double Area { get; }
        public override string ToString()
        {
            return string.Format("It is a two-dimensional shape!");
        }
    }
}
