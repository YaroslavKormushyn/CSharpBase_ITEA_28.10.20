using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeClass
{
    class Cube : ThreeDimensionalShape
    {
        public Cube(double a) : base(a)
        {
        }
        public override double Area
        {
            get { return 6 * Math.Pow(base.Side, 2); }
        }

        public override double Volume
        {
            get { return Math.Pow(base.Side, 3); }
        }

        public override string ToString()
        {
            return "It is a cube! " + base.ToString();
        }

    }
}
