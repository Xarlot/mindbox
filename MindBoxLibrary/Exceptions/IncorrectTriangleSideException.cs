namespace MindBoxLibrary.Exceptions;

public class IncorrectTriangleSideException : Exception {
    public IncorrectTriangleSideException() : base("Triangle sides should be greater or equals to 0") {
    }
}