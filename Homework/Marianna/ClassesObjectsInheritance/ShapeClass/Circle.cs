using System;
using System.Collections.Generic;
using System.Text;

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
            return string.Format("It is a circle! " + base.ToString());
        }
    }
}