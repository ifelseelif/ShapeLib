namespace ShapeSquareLib.Shapes.Basic
{
    public class Triangle : IShape
    {
        public double Tolerance { get; }
        public double[] Sides { get; }

        public Triangle(double side1, double side2, double side3, double tolerance = 0.000001d)
        {
            if (Math.Abs(Math.Abs(side1 + side2 + side3) - (side1 + side2 + side3)) > tolerance)
            {
                throw new ArgumentException("Side should be greater that zero");
            }
        
            var sides = new[] { side1, side2, side3 };
            Array.Sort(sides);
            if (sides[2] >= sides[0] + sides[1])
                throw new ArgumentException("Triangle cannot have a larger side smaller than the other two");

            Tolerance = tolerance;
            Sides = sides;
        }

        public double CalculateSquare()
        {
            if (IsRightTriangle()) return Sides[0] * Sides[1] / 2;

            var halfPerimeter = Sides.Sum() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - Sides[0]) * (halfPerimeter - Sides[1]) *
                             (halfPerimeter - Sides[2]));
        }

        private bool IsRightTriangle()
        {
            return Math.Abs(Math.Pow(Sides[2], 2) - Math.Pow(Sides[0],2) + Math.Pow(Sides[1], 2)) < Tolerance;
        }
    }
}