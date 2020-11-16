using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClass
{
    class Square: TwoDimensionalShape
    {
        public Square(double a) : base(a)
        {

        }
        public override double Area
        {
            get { return Math.Pow(base.Side, 2); }
        }
        public override string ToString()
        {
            return string.Format("It is a square! "+base.ToString());
        }
    }
}
