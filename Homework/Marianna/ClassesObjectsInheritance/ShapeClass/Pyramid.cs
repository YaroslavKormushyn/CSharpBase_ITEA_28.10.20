using System;

namespace ShapeClass
{
    class Pyramid : ThreeDimensionalShape
    {
        public Pyramid(double a, double sideheight, double pyramidHeight) : base(a)
        {
            Apophema = sideheight;
            Height = pyramidHeight;
        }
        public double Apophema { get; set; }
        public double Height { get; set; }
        public override double Area
        {
            get { return Math.Pow(base.Side, 2) * Math.Pow(3, 1 / 2) / 4 + base.Side * 3 * Apophema; }
        }
        public override double Volume
        {
            get { return Math.Pow(base.Side, 2) * Math.Pow(3, 1 / 2) / 4 * Height / 3; }
        }
        public override string ToString()
        {
            return "It is a pyramid! " + base.ToString();
        }
    }
}
