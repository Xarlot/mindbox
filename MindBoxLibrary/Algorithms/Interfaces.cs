namespace MindBoxLibrary.Algorithms; 

public interface IAreaCalculator<in T> where T: IShape {
    double Calculate(T shape);
}

public interface IRightTriangleDetector {
    bool IsRightTriangle(Triangle triangle);
}