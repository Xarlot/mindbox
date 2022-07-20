namespace MindBoxLibrary.Exceptions; 

public class NotRegisteredShapeException : Exception {
    public NotRegisteredShapeException() : base("Register your shape") {
        
    }
}