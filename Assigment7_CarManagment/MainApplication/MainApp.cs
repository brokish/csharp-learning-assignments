using Assigment7_CarManagment.Services;
using Assigment7_CarManagment.WalletService;
using Homework.Helpers;

namespace Assigment7_CarManagment.MainApplication;

public class MainApp
{
    private readonly BankAccount bankAccount = new();
    private readonly RefParamAssigment refParamAssigment = new();

    public void FuelTracking()
    {
        Console.WriteLine(
            "შეიყვანეთ 3 დღის განმავლობაში დამწვარი ბენზინის რაოდენობა დღეების მიხედვით და გამოგითვლით საშუალო წვას");

        Console.Write("შეიყვანეთ პირველი დღის წვა ლიტრში ");
        var day1 = SharedUtils.ParseStringToDouble(Console.ReadLine());

        Console.Write("შეიყვანეთ მეორე დღის წვა ლიტრში ");
        var day2 = SharedUtils.ParseStringToDouble(Console.ReadLine());

        Console.Write("შეიყვანეთ მესამე დღის წვა ლიტრში ");
        var day3 = SharedUtils.ParseStringToDouble(Console.ReadLine());

        var averageLiter = CarFuelAnalytic.CalculateAverage(day1, day2, day3);

        Console.WriteLine($"თქვენი საშუალო წვა არის {averageLiter} ლიტრი");
    }

    public void ParkingPayment()
    {
        Console.WriteLine("შეიყვანეთ რა თანხის გადარიცხვა გსურთა პარკირების აპლიკაციაში");

        var parkingAmont = SharedUtils.ParseStringToDouble(Console.ReadLine());

        Console.WriteLine($"თქვენ გადარიცხეთ პარკირების აპლიკაციაში {parkingAmont} ლარი");

        Console.WriteLine("ანგარიშზე არსებული ნაშთია ");
        bankAccount.Deposit(parkingAmont);
        bankAccount.ShowBalance();
    }

    public void printSwapRepParams()
    {
        Console.WriteLine("შეიყვანეთ პირველი პარამეტრი");
        var firstParam = SharedUtils.ParseStringToInt(Console.ReadLine());
        var secondParam = SharedUtils.ParseStringToInt(Console.ReadLine());

        Console.WriteLine($"პირველადი  პარამეტრები არის: firstParam = {firstParam}, secondParam = {secondParam}");

        refParamAssigment.SwapNumbers(ref firstParam, ref secondParam);

        Console.WriteLine($"გადაცვლის შემდგომი შედეგი: firstParam = {firstParam}, secondParam = {secondParam}");
    }
}