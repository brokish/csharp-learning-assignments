namespace Assigment8.Services;

public class AreaCalculator
{
    public const double P = 3.14;
    public readonly double Radius;

    public AreaCalculator(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        double area = P * Radius * Radius;
        return area;
    }
}