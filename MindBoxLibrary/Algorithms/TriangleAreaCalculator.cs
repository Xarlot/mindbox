using MindBoxLibrary.Validation.Internal;

namespace MindBoxLibrary.Algorithms;

public class TriangleAreaCalculator : IAreaCalculator<Triangle> {
    private readonly IShapeValidator<Triangle> validator;
    public TriangleAreaCalculator(IShapeValidator<Triangle> validator) {
        this.validator = validator;
    }

    public double Calculate(Triangle shape) {
        validator.Validate(shape);

        double p = (shape.A + shape.B + shape.C) / 2;
        return Math.Sqrt(p * (p - shape.A) * (p - shape.B) * (p - shape.C));
    }
}