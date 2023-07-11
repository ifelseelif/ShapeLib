namespace ShapeSquareLib.Shapes.Basic
{
    public class Rectangle : IShape
    {
        public double Weight { get; }
        public double Height { get; }

        public Rectangle(double weight, double height)
        {
            if (weight <= 0)
            {
                throw new ArgumentException($"{nameof(weight)} should be greater or equal than 0");
            }
        
            if (height <= 0)
            {
                throw new ArgumentException($"{nameof(height)} should be greater or equal than 0");
            }
        
            Weight = weight;
            Height = height;
        }

        public double CalculateSquare()
        {
            return Weight * Height;
        }
    }
}