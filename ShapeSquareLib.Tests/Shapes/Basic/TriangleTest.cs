using ShapeSquareLib.Shapes.Basic;
using Xunit;

namespace ShapeSquareLib.Tests.Shapes.Basic;

public class TriangleTest
{
    private static readonly Random Random = new();

    [Theory]
    [MemberData(nameof(Ctor_WhenArgumentLessThanZero_DataGenerator))]
    public void Ctor_WhenArgumentLessOrEqualThanZero_ShouldThrowArgumentException(double side1, double side2,
        double side3)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
    }

    public static IEnumerable<object[]> Ctor_WhenArgumentLessThanZero_DataGenerator()
    {
        yield return new object[] { 0, 1, 1 };
        yield return new object[] { 1, 0, 1 };
        yield return new object[] { 1, 1, 0 };
    }

    [Fact]
    public void Ctor_WhenLargerSideSmallerThanOthers_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 5, 3));
    }

    [Fact]
    public void CalculateSquare_WhenTriangleIsRight_ShouldReturnSquare()
    {
        var leg1 = 3;
        var leg2 = 4;
        var hypotenus = 5;
        var triangle = new Triangle(hypotenus, leg1, leg2);

        var square = triangle.CalculateSquare();

        Assert.Equal(leg1 * leg2 / 2, square);
    }

    [Fact]
    public void CalculateSquare_WhenTriangleIsNotRight_ShouldReturnSquare()
    {
        var triangle = new Triangle(7, 6, 5);

        var square = triangle.CalculateSquare();

        var expectedHalfPerimeter = triangle.Sides.Sum() / 2;
        var expectedResult = Math.Sqrt(expectedHalfPerimeter * (expectedHalfPerimeter - triangle.Sides[0]) *
                                       (expectedHalfPerimeter - triangle.Sides[1]) *
                                       (expectedHalfPerimeter - triangle.Sides[2]));
        Assert.Equal(expectedResult, square);
    }
}