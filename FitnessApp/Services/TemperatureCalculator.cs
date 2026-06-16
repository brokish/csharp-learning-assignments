using Homework.Helpers;

namespace FitnessApp.Services;

public static class TemperatureCalculator
{

    public static void ReturnCorrectTemperature()
    {
        Console.WriteLine("შეიყვანეთ რომელ გრადუსზე გსურთ ტემპერატურის არჩევა");
        string temperatureInCelsius = Console.ReadLine().ToUpper();
        while (temperatureInCelsius != "C" && temperatureInCelsius != "F")
        {
            Console.WriteLine("გთხოვთ შეიყვანოთ სწორი ტემპერატურის ერთეული");
            temperatureInCelsius = Console.ReadLine();

        }
 

        if (temperatureInCelsius == "C")
        {
            Console.WriteLine("შეიყვანეთ სასურველი ტემპერატურა ციფრებში");
            double doubleInput = SharedUtils.ParseStringToDouble(Console.ReadLine());
            CelsiusToFahrenheit(doubleInput);
        }
        else if (temperatureInCelsius == "F")
        {
            Console.WriteLine("შეიყვანეთ სასურველი ტემპერატურა ციფრებში");
            double doubleInput = SharedUtils.ParseStringToDouble(Console.ReadLine());
            FahrenheitToCelsius(doubleInput);
        }
        else
        {
            Console.WriteLine("დაფიქსირდა შეცდომა");
        }
        
    }
    
    
    public static void CelsiusToFahrenheit(double doubleInput)
    {
            double Fahrenheit = (doubleInput * 9 / 5) + 32 ;
            Console.WriteLine($"თქვენი ტემპერატურა ფარენჰეიტშია: {Fahrenheit}");

    }

    public static void FahrenheitToCelsius(double doubleInput)
    { 
            double celsius = (doubleInput - 32) * 5 / 9;
            Console.WriteLine($"თქვენი ტემპერატურა ცელსიუსში: {celsius}");
    }
   
    
}