using Assigment8.Services;
using Homework.Helpers;

public class DistanceTrackingApp
{
    public void Run()
    {
        Console.WriteLine(Converter.AppName);

        Console.WriteLine("შეიყვანეთ შესაბამისი ციფრი რისი კონვერტაციაც გსურთ");
        Console.WriteLine("1 - კილომეტრიდან მილში");
        Console.WriteLine("2 - მილიდან კილომეტრში");

        int choice = SharedUtils.ParseStringToInt(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("შეიყვანეთ კილომეტი");

            double kilometer = SharedUtils.ParseStringToDouble(Console.ReadLine());

            double result = Converter.KmToMiles(kilometer);

            Console.WriteLine(result);
        }
        else if (choice == 2)
        {
            MilesToKilometer();
        }
        else
        {
            Console.WriteLine("მოხდა შეცოდმა");
        }
    }

    public void MilesToKilometer() 
    {
        Console.WriteLine("შეიყვანეთ მილი");
        double mile = SharedUtils.ParseStringToDouble(Console.ReadLine());

        double result = Converter.MileToKm(mile);
        Console.WriteLine(result);
    }
}