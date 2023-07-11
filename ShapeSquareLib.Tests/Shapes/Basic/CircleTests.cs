using ShapeSquareLib.Shapes.Basic;
using Xunit;

namespace ShapeSquareLib.Tests.Shapes.Basic;

public class CircleTests
{
    private static readonly Random Random = new();
    
    [Fact]
    public void Ctor_WhenRadiusLessThanZero_ShouldThrowArgumentException()
    {
        var radius = Random.Next(int.MinValue, -1);
        
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
    
    [Fact]
    public void CalculateSquare_WhenRadiusGreaterThanZero_ShouldReturnSquare()
    {
        var radius = Random.Next(0, int.MaxValue);
        var circle = new Circle(radius);

        var square = circle.CalculateSquare();
        
        Assert.Equal(2 * Math.PI * radius, square);
    }
}