using MindBoxLibrary.Exceptions;

namespace MindBoxLibrary.Validation.Internal; 

public class CircleValidator : IShapeValidator<Circle> {
    public void Validate(Circle circle) {
        if (circle.Radius < 0)
            throw new IncorrectCircleRadiusException();
    }
}