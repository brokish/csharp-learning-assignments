namespace CarRentApp;

public class Car
{
    public string CarModel;
    public int dayRange;
    public int PricePerDay;
    public int Year;

    public Car(string carModel, int year, int pricePerDay, int dayRange)
    {
        CarModel = carModel;
        Year = year;
        PricePerDay = pricePerDay;
        this.dayRange = dayRange;
    }

    public void ShowRentalDetails()
    {
        Console.WriteLine($"არჩეული მანქანის მოდელი: {CarModel}");
        Console.WriteLine($"მანქანის წლოვანება: {Year} ");
        Console.WriteLine($"რამდენი დღით გსურთ ქირაობა: {dayRange} ");
        Console.WriteLine($"ჯამური გადასახდელი თანხა: {PricePerDay} ");
    }
}