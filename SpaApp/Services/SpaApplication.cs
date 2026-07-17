using FitnessApp.PartialClasses;
using Homework.Helpers;

namespace FitnessApp.Services;

public class SpaApplication
{
    public static void ApplicationRunner()
    {
        Console.WriteLine("გთხოვთ მიყვეთ ინსტრუქციას რათა დაჯავშნოთ დისტანციურად ჩვენი სერვისი");

        Console.WriteLine("გთხოვთ შეიყვანოთ თქვენი სახელი");
        var name = Console.ReadLine();
        var nameCountVowels1 = name.CountVowels();


        if (nameCountVowels1 > 2) Console.WriteLine("თქვენი სახელი ჟღერადია");

        TemperatureCalculator.ReturnCorrectTemperature();

        Console.WriteLine("გთხოვთ შეიყვანოთ თქვენი ნომერი");
        var number = SharedUtils.ParseStringToInt(Console.ReadLine());
        Console.WriteLine("ჯავშანის კოდი გამოგეგზავნებათ ამ ნომერზე " + number);

        var customer = new Customers();
        customer.Display();
    }
}