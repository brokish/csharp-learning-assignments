namespace Assigment12_Exeptions.Exeptions;

public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}