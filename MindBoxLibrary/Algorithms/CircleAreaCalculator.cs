using MindBoxLibrary.Validation.Internal;

namespace MindBoxLibrary.Algorithms;

internal class CircleAreaCalculator : IAreaCalculator<Circle> {
    private readonly IShapeValidator<Circle> validator;
    public CircleAreaCalculator(IShapeValidator<Circle> validator) {
        this.validator = validator;
    }
    
    public double Calculate(Circle shape) {
        validator.Validate(shape);
        
        return shape.Radius * shape.Radius * Math.PI;
    }
}