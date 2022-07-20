namespace MindBoxLibrary.Exceptions; 

public class IncorrectCircleRadiusException : Exception {
    public IncorrectCircleRadiusException() : base("Radius should be greater or equal to 0") {
        
    }
}