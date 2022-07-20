using MindBoxLibrary.Validation.Internal;

namespace MindBoxLibrary.Algorithms; 

public class RightTriangleDetector : IRightTriangleDetector {
    private readonly IShapeValidator<Triangle> validator;
    public RightTriangleDetector(IShapeValidator<Triangle> validator) {
        this.validator = validator;
    }
    public bool IsRightTriangle(Triangle triangle) {
        validator.Validate(triangle);
        
        var sides = new[] { triangle.A, triangle.B, triangle.C }.OrderByDescending(x => x).ToArray();
        return Math.Abs(sides[0] * sides[0] - (sides[1] * sides[1] + sides[2] * sides[2])) < double.Epsilon;
    }
}

