namespace Assigment12_Exeptions.Exeptions;

public class InvalidPriceException : Exception
{
    public InvalidPriceException(string message) : base(message)
    {
    }
}