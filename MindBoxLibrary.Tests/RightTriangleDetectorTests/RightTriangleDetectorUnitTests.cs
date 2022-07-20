using Autofac;
using MindBoxLibrary.Validation;
using MindBoxLibrary.Validation.Internal;
using NSubstitute;
using Xunit;

namespace MindBoxLibrary.Tests; 

public class RightTriangleDetectorTests {
    [Fact]
    public void TriangleValidatorTest() {
        var validator = Substitute.For<IShapeValidator<Triangle>>();
        using var factory = new ApiFactory(builder => {
            builder.RegisterInstance(validator).As<IShapeValidator<Triangle>>();
        });
        
        var calculator = factory.CreateRightTriangleDetector();
        var triangle = new Triangle(3, 4, 5);
        calculator.IsRightTriangle(triangle);
        
        validator.Received(1).Validate(triangle);
    }
}