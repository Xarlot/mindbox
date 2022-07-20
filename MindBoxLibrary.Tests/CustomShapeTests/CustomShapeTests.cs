using Autofac;
using FluentAssertions;
using MindBoxLibrary.Algorithms;
using Xunit;

namespace MindBoxLibrary.Tests.CustomShapesTests; 

public class CustomShapeTests {
    [Fact]
    public void RegisterCustomShape() {
        using var factory = new ApiFactory(builder => {
            builder.RegisterType<CustomShapeCalculator>().As<IAreaCalculator<CustomShape>>();
        });
        factory.CreateAreaCalculator<CustomShape>().Calculate(new CustomShape()).Should().Be(333);
    }
}