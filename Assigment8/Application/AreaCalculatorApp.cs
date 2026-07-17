using Assigment8.Services;
using Homework.Helpers;

namespace Assigment8.Application;

public class AreaCalculatorApp
{
    public void Run()
    {
        Console.Write("შეიყვანეთ რადიუსი");

        var radius = SharedUtils.ParseStringToDouble(Console.ReadLine());

        var myCircle = new AreaCalculator(radius);

        var areaResult = myCircle.CalculateArea();

        Console.WriteLine($"ფართობი არის : {areaResult}");
    }
}