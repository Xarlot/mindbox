namespace MindBoxLibrary.Exceptions;

public class IncorrectTriangleException : Exception {
    public IncorrectTriangleException() : base("Triangle sides should match the a + b <= c") {
    }
}