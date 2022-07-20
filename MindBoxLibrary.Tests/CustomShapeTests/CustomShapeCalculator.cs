using MindBoxLibrary.Algorithms;

namespace MindBoxLibrary.Tests.CustomShapesTests; 

public class CustomShapeCalculator : IAreaCalculator<CustomShape> {
    public double Calculate(CustomShape shape) {
        return 333;
    }
}