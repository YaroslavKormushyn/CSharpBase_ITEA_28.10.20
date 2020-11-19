using System;

namespace ShapeClass
{
    class Sphere : ThreeDimensionalShape
    {
        public Sphere(double a) : base(a)
        {
        }
        public override double Area
        {
            get { return Math.PI * 4 * Math.Pow(base.Side, 2); }
        }

        public override double Volume
        {
            get { return (4 / 3) * Math.PI * Math.Pow(base.Side, 3); }
        }

        public override string ToString()
        {
            return "It is a sphere! " + base.ToString();
        }
    }
}
