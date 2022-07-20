namespace MindBoxLibrary.Validation.Internal; 

public interface IShapeValidator<in T> where T: IShape {
    void Validate(T shape);
}