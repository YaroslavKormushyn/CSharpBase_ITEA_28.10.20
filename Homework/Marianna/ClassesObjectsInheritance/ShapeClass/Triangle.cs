using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClass
{
    class Triangle : TwoDimensionalShape
    {
        public Triangle(double a, double height) : base(a)
        {
            H = height;
        }
        public double H { get; set; }
        public override double Area
        {
            get { return base.Side*H/2; }
        }
        public override string ToString()
        {
            return string.Format("It is a triangle! " + base.ToString());
        }
    }
}