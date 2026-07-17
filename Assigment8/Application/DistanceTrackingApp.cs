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

        var choice = SharedUtils.ParseStringToInt(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("შეიყვანეთ კილომეტი");

            var kilometer = SharedUtils.ParseStringToDouble(Console.ReadLine());

            var result = Converter.KmToMiles(kilometer);

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
        var mile = SharedUtils.ParseStringToDouble(Console.ReadLine());

        var result = Converter.MileToKm(mile);
        Console.WriteLine(result);
    }
}