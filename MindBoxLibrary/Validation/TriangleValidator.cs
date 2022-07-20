using MindBoxLibrary.Exceptions;

namespace MindBoxLibrary.Validation.Internal;

public class TriangleValidator : IShapeValidator<Triangle> {
    public void Validate(Triangle shape) {
        if (shape.A < 0 || shape.B < 0 || shape.C < 0)
            throw new IncorrectTriangleSideException();
        if (shape.A + shape.B <= shape.C || shape.A + shape.C <= shape.B || shape.B + shape.C <= shape.A)
            throw new IncorrectTriangleException();
    }
}