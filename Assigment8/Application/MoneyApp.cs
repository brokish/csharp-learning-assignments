using Assigment8.Services;

namespace Assigment8.Application;

public class MoneyApp
{
    public void Run()
    {
  

        Console.Write("შეიყვანეთ m1 - ");
        double amount1 = Homework.Helpers.SharedUtils.ParseStringToDouble(Console.ReadLine());
        Money m1 = new Money(amount1);

        Console.Write("შეიყვანეთ m2-ის - ");
        double amount2 = Homework.Helpers.SharedUtils.ParseStringToDouble(Console.ReadLine());
        Money m2 = new Money(amount2);

        Money resultPlus = m1 + m2;
        Console.WriteLine($"ჯამი: {resultPlus.Amount}"); 

   
        Money resultMinus = m2 - m1;
        Console.WriteLine($"სხვაობა: {resultMinus.Amount}"); 

 
        bool areEqual = (m1 == m2);
        Console.WriteLine($"ტოლობა: {areEqual}");
    }
}