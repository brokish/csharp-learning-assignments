using Homework.Helpers;

namespace CarRentApp;

public class RentApp
{
    private readonly int insurancePrice = 30;
    private readonly int pricePerDay = 100;

    public void CarRentApplication()
    {
        Console.Write("შეიყვანეთ თქვენი სახელი ");
        var inputName = Console.ReadLine();

        Console.Write("შეიყვანეთ თქვენი გვარი ");
        var inputSurname = Console.ReadLine();

        Console.Write("შეიყვანეთ თქვენი ასაკი ");
        var inputAge = SharedUtils.ParseStringToInt(Console.ReadLine());

        var client = new Customers(inputName, inputSurname, inputAge);
        client.ShowClientInfo();
        var currentStatus = StatusesEnum.Pending;
        if (inputAge < 18)
        {
            currentStatus = StatusesEnum.Rejected;
            Console.WriteLine("18 წლამდე პირებისთვის მანქანის გაქირავება დაუშვებელია");
            Console.WriteLine($"შეკვეთის სტატუსი: {currentStatus}");
            return;
        }


        Console.WriteLine($"წარმატებით გაიარეთ ვერიფიკაცია status = {currentStatus}");

        Console.Write("შეიყვანეთ მანქანის მოდელი (მაგ: BMW, Mercedes, Toyota, Jeep, Ford): ");
        var inputModel = Console.ReadLine();

        string[] availableCars = { "bmw", "mercedes", "toyota", "jeep", "ford" };

        while (!availableCars.Contains(inputModel.ToLower()))
        {
            currentStatus = StatusesEnum.Rejected;
            Console.WriteLine($"'{inputModel}' ჩვენს ბაზაში არ მოიძებნა.");
            Console.WriteLine($"შეკვეთის სტატუსი: {currentStatus}");
            Console.WriteLine($"აირჩიეთ ჩვენს ბაზაში არსებული მანქანები : {string.Join(", ", availableCars)}");

            inputModel = Console.ReadLine();
        }

        Console.Write("შეიყვანეთ მანქანის გამოშვების წელი: ");
        var carYear = SharedUtils.ParseStringToInt(Console.ReadLine());

        Console.Write("რამდენი დღით გსურთ ქირაობა?: ");
        var rentDays = SharedUtils.ParseStringToInt(Console.ReadLine());


        var totalPayment = Calculator.Multiply(rentDays, pricePerDay);
        var totalPaymentWithInsurance = Calculator.Add(totalPayment, insurancePrice);
        var car = new Car(inputModel, carYear, pricePerDay, rentDays);

        Console.WriteLine("შეკვეთის დეტალები");
        car.ShowRentalDetails();

        currentStatus = StatusesEnum.Approved;
        Console.WriteLine($"მანქანის თანხა {totalPayment} ლარი status = {currentStatus}");

        Console.WriteLine($"მანქანის ფასი დაზღვვევით {totalPaymentWithInsurance} ლარი. დაზვევა სავალდებულოა");
    }
}