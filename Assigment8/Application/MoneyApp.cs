using Assigment8.Services;
using Homework.Helpers;

namespace Assigment8.Application;

public class MoneyApp
{
    public void Run()
    {
        Console.Write("შეიყვანეთ m1 - ");
        var amount1 = SharedUtils.ParseStringToDouble(Console.ReadLine());
        var m1 = new Money(amount1);

        Console.Write("შეიყვანეთ m2-ის - ");
        var amount2 = SharedUtils.ParseStringToDouble(Console.ReadLine());
        var m2 = new Money(amount2);

        var resultPlus = m1 + m2;
        Console.WriteLine($"ჯამი: {resultPlus.Amount}");


        var resultMinus = m2 - m1;
        Console.WriteLine($"სხვაობა: {resultMinus.Amount}");


        var areEqual = m1 == m2;
        Console.WriteLine($"ტოლობა: {areEqual}");
    }
}