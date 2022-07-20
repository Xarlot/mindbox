using FluentAssertions;
using MindBoxLibrary.Exceptions;
using MindBoxLibrary.Validation;
using MindBoxLibrary.Validation.Internal;
using Xunit;

namespace MindBoxLibrary.Tests; 

public class ShapeValidatorUnitTests {
    [Fact]
    public void  CircleValidatorTest() {
        var validator = new CircleValidator();

        Action action = () => validator.Validate(new Circle(10));
        action.Should().NotThrow();
    }
    [Fact]
    public void  CircleValidatorNegationTest() {
        var validator = new CircleValidator();

        Action action = () => validator.Validate(new Circle(-10));
        action.Should().Throw<IncorrectCircleRadiusException>();
    }
    [Fact]
    public void TriangleValidatorTest() {
        var validator = new TriangleValidator();

        Action action = () => validator.Validate(new Triangle(3, 4, 5));
        action.Should().NotThrow();
    }
    [Fact]
    public void  TriangleValidator_ValidateSidesTest() {
        var validator = new TriangleValidator();

        Action action = () => validator.Validate(new Triangle(-3, 4, 33));
        action.Should().Throw<IncorrectTriangleSideException>();
        
        Action action2 = () => validator.Validate(new Triangle(3, -4, 33));
        action2.Should().Throw<IncorrectTriangleSideException>();
        
        Action action3 = () => validator.Validate(new Triangle(3, 4, -33));
        action3.Should().Throw<IncorrectTriangleSideException>();
    }
    [Fact]
    public void  TriangleValidator_ValidateStructureTest() {
        var validator = new TriangleValidator();

        Action action = () => validator.Validate(new Triangle(3, 4, 33));
        action.Should().Throw<IncorrectTriangleException>();
    }
}