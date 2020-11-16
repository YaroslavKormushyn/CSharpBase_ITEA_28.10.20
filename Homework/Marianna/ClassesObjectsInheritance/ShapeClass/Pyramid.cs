using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClass
{
    class Pyramid : ThreeDimensionalShape
    {
        public Pyramid(double a, double sideheight, double pyramidHeight) : base(a)
        {
            Apophema = sideheight;
            PyramidH = pyramidHeight;
        }
        public double Apophema { get; set; }
        public double PyramidH { get; set; }
        public override double Area
        {
            get { return Math.Pow(base.Side, 2)* Math.Pow(3, 1/2)/4+  base.Side*3 * Apophema; }
        }
        public override double Volume
        {
            get { return Math.Pow(base.Side, 2) * Math.Pow(3, 1 / 2) / 4 * PyramidH / 3;  }
        }
        public override string ToString()
        {
            return string.Format("It is a pyramid! " + base.ToString());
        }
    }
}
