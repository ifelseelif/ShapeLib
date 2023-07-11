namespace ShapeSquareLib.Shapes.Basic
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException($"{nameof(radius)} should be greater or equal than 0");
            }

            Radius = radius;
        }

        public double CalculateSquare()
        {
            return 2d * Math.PI * Radius;
        }
    }
}