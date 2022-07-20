using FluentAssertions;
using Xunit;

namespace MindBoxLibrary.Tests; 

public class RightTriangleDetectorFunctionalTests : IDisposable {
    private readonly ApiFactory factory = new();
    
    [Fact]
    public void RightTriangleDetectorTest() {
        var detector = factory.CreateRightTriangleDetector();

        detector.IsRightTriangle(new Triangle(3, 4, 5)).Should().BeTrue();
    }
    [Fact]
    public void RightTriangleDetectorNegationTest() {
        var detector = factory.CreateRightTriangleDetector();

        detector.IsRightTriangle(new Triangle(3, 4, 6)).Should().BeFalse();
    }
    public void Dispose() {
        factory?.Dispose();
    }
}