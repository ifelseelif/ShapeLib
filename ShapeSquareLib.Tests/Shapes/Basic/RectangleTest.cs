using ShapeSquareLib.Shapes.Basic;
using Xunit;

namespace ShapeSquareLib.Tests.Shapes.Basic;

public class RectangleTest
{
    private static readonly Random Random = new();

    [Theory]
    [MemberData(nameof(Ctor_WhenArgumentLessThanZero_DataGenerator))]
    public void Ctor_WhenArgumentLessOrEqualThanZero_ShouldThrowArgumentException(double height, double weight)
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(height, weight));
    }

    public static IEnumerable<object[]> Ctor_WhenArgumentLessThanZero_DataGenerator()
    {
        yield return new object[] { Random.Next(1, int.MaxValue), Random.Next(int.MinValue, 0) };
        yield return new object[] { Random.Next(int.MinValue, 0), Random.Next(1, int.MaxValue) };
    }

    [Fact]
    public void CalculateSquare_WhenHeightAndWeightGreaterThanZero_ShouldReturnSquare()
    {
        double height = Random.Next(1, int.MaxValue);
        double weight = Random.Next(1, int.MaxValue);
        var rectangle = new Rectangle(weight: weight, height: height);

        var square = rectangle.CalculateSquare();

        Assert.Equal(height * weight, square);
    }
}