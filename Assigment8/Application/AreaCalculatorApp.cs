using Assigment8.Services;
using Homework.Helpers;

namespace Assigment8.Application;

public class AreaCalculatorApp
{
    public void Run()
    {
        Console.Write("შეიყვანეთ რადიუსი");
        
        double radius = SharedUtils.ParseStringToDouble(Console.ReadLine());

        AreaCalculator myCircle = new AreaCalculator(radius);

        double areaResult = myCircle.CalculateArea();

        Console.WriteLine($"ფართობი არის : {areaResult}");
    }
}