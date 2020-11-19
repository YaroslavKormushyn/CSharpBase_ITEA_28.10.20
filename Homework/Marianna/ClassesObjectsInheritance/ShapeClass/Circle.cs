using System;

namespace ShapeClass
{
    class Circle : TwoDimensionalShape
    {
        public Circle(double a) : base(a)
        {
        }
        public override double Area
        {
            get { return Math.PI * Math.Pow(base.Side, 2); }
        }

        public override string ToString()
        {
            return "It is a circle! " + base.ToString();
        }
    }
}