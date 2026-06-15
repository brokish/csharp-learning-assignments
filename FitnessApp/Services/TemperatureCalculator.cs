using Homework.Helpers;

namespace FitnessApp.Services;

public static class TemperatureCalculator
{

    public static void returnCorrectTemperature()
    {
        Console.WriteLine("შეიყვანეთ რომელ გრადუსზე გსურთ ტემპერატურის არჩევა");
        string temperatureInCelsius = Console.ReadLine();
        
        Console.WriteLine("შეიყვანეთ სასურველი ტემპერატურა ციფრებში");
        int intInput = int.Parse(Console.ReadLine());

        if (temperatureInCelsius == "Celsius")
        {
            CelsiusToFahrenheit(intInput);
        }
        else if (temperatureInCelsius == "Fahrenheit")
        {
            FahrenheitToCelsius(intInput);
        }
        else
        {
            Console.WriteLine("გთხოვთ შეიყვანოთ სწორი ტემპერატურის ერთეული");
        }
        
    }
    
    
    public static void CelsiusToFahrenheit(int intInput)
    {
            int Fahrenheit = (intInput * 9 / 5) + 32 ;
            Console.WriteLine($"თქვენი ტემპერატურა ფარენჰეიტშია: {Fahrenheit}");

    }

    public static void FahrenheitToCelsius(int intInput)
    { 
            int celsius = (intInput - 32) * 5 / 9;
            Console.WriteLine($"თქვენი ტემპერატურა ცელსიუსში: {celsius}");
    }
   
    
}