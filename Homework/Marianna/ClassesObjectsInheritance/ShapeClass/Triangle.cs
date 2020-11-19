using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClass
{
    class Triangle : TwoDimensionalShape
    {
        public Triangle(double a, double height) : base(a)
        {
            Height = height;
        }
        public double Height { get; set; }

        public override double Area
        {
            get { return base.Side* Height / 2; }
        }

        public override string ToString()
        {
            return "It is a triangle! " + base.ToString();
        }

    }
}