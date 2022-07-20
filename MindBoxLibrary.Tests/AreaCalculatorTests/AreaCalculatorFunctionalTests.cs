using FluentAssertions;
using MindBoxLibrary.Exceptions;
using Xunit;

namespace MindBoxLibrary.Tests; 

public class AreaCalculatorFunctionalTests : IDisposable {
    private readonly ApiFactory factory;
    public AreaCalculatorFunctionalTests() {
        factory = new ApiFactory();
    }
    
    [Fact]
    public void CircleAreaTest() {
        var calculator = factory.CreateAreaCalculator<Circle>();
        
        calculator.Calculate(new Circle(0)).Should().Be(0);
        calculator.Calculate(new Circle(30)).Should().Be(30 * 30 * Math.PI);
    }
    [Fact]
    public void CircleAreaNegationTest() {
        var calculator = factory.CreateAreaCalculator<Circle>();
       
        var action = () => calculator.Calculate(new Circle(-30));
        action.Should().Throw<IncorrectCircleRadiusException>();
    }
    
    [Fact]
    public void TriangleAreaTest() {
        var calculator = factory.CreateAreaCalculator<Triangle>();
        
        calculator.Calculate(new Triangle(3, 4, 5)).Should().Be(6);
    }
    [Fact]
    public void TriangleAreaNegationTest() {
        var calculator = factory.CreateAreaCalculator<Triangle>();
        
        var action = () => calculator.Calculate(new Triangle(3, 4, 8));
        action.Should().Throw<IncorrectTriangleException>();
    }
    public void Dispose() {
        factory?.Dispose();
    }
}