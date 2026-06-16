using Homework.Helpers;

namespace FitnessApp.Services;
public class SpaApp
{
    public static void run()
    {
    Console.WriteLine("გთხოვთ მიყვეთ ინსტრუქციას რათა დაჯავშნოთ დისტანციურად ჩვენი სერვისი");
    
    Console.WriteLine("გთხოვთ შეიყვანოთ თქვენი სახელი");
    string name = Console.ReadLine();
    int nameCountVowels1 = name.CountVowels();

    
    if (nameCountVowels1 > 2)
    {
        Console.WriteLine("თქვენი სახელი ჟღერადია");
    }

    TemperatureCalculator.ReturnCorrectTemperature();
    
    Console.WriteLine("გთხოვთ შეიყვანოთ თქვენი ნომერი");
    int number = SharedUtils.ParseStringToInt(Console.ReadLine());
    Console.WriteLine("ჯავშანის კოდი გამოგეგზავნებათ ამ ნომერზე " + number);
    }
}