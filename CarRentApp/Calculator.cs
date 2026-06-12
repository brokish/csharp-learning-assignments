using System.ComponentModel;

namespace CarRentApp;

public class Calculator
{
    public static int Multiply(int days, int pricePerDay)
    {
        return days * pricePerDay;
    }

    public static int Add(int basePrice, int insurancePrice)
    {
        return basePrice + insurancePrice;
    }
}