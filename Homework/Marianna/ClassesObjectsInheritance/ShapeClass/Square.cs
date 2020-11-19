using System;

namespace ShapeClass
{
    class Square : TwoDimensionalShape
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
            return "It is a square! " + base.ToString();
        }
    }
}
