using Autofac;
using MindBoxLibrary.Validation.Internal;
using NSubstitute;
using Xunit;

namespace MindBoxLibrary.Tests; 

public class AreaCalculatorUnitTests {
    [Fact]
    public void CircleValidatorTest() {
        var validator = Substitute.For<IShapeValidator<Circle>>();
        using var factory = new ApiFactory(builder => {
            builder.RegisterInstance(validator).As<IShapeValidator<Circle>>();
        });
        
        var calculator = factory.CreateAreaCalculator<Circle>();
        var circle = new Circle(10);
        calculator.Calculate(circle);
        
        validator.Received(1).Validate(circle);
    }
    [Fact]
    public void TriangleValidatorTest() {
        var validator = Substitute.For<IShapeValidator<Triangle>>();
        using var factory = new ApiFactory(builder => {
            builder.RegisterInstance(validator).As<IShapeValidator<Triangle>>();
        });
        
        var calculator = factory.CreateAreaCalculator<Triangle>();
        var triangle = new Triangle(3, 4, 5);
        calculator.Calculate(triangle);
        
        validator.Received(1).Validate(triangle);
    }
}