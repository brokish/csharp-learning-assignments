namespace Assigment7_CarManagment.Services;

public static class CarFuelAnalytic
{
    public static double CalculateAverage(double first, double second, double third)
    {
        var averageLiter = (first + second + third) / 3;
        return averageLiter;
    }
}