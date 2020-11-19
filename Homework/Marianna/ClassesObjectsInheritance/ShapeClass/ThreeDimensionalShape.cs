namespace ShapeClass
{
    abstract class ThreeDimensionalShape : Shape
    {
        public ThreeDimensionalShape(double a) : base(a)
        {
        }
        public override abstract double Area { get; }

        public abstract double Volume { get; }

        public override string ToString()
        {
            return "It is a three-dimensional shape!";
        }
    }
}