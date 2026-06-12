using Homework.Helpers;

namespace CarRentApp;

public class RentApp
{
    
    int pricePerDay = 100;
    int insurancePrice = 30;
    public void CarRentApplication()
    {

        Console.Write("შეიყვანეთ თქვენი სახელი ");
        string inputName = Console.ReadLine();
        
        Console.Write("შეიყვანეთ თქვენი გვარი ");
        string inputSurname = Console.ReadLine();
        
        Console.Write("შეიყვანეთ თქვენი ასაკი ");
        int inputAge = SharedUtils.ParseStringToInt(Console.ReadLine());
        
        Customers client = new Customers(inputName, inputSurname, inputAge);
        client.ShowClientInfo();
        StatusesEnum currentStatus = StatusesEnum.Pending;
        if (inputAge < 18)
        {
            currentStatus = StatusesEnum.Rejected;
            Console.WriteLine("18 წლამდე პირებისთვის მანქანის გაქირავება დაუშვებელია");
            Console.WriteLine($"შეკვეთის სტატუსი: {currentStatus}");
            return;
        }
        
        
        Console.WriteLine($"წარმატებით გაიარეთ ვერიფიკაცია status = {currentStatus}");
  
        Console.Write("შეიყვანეთ მანქანის მოდელი (მაგ: BMW, Mercedes, Toyota, Jeep, Ford): ");
        string inputModel = Console.ReadLine();

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
        int carYear = SharedUtils.ParseStringToInt(Console.ReadLine());
        
        Console.Write("რამდენი დღით გსურთ ქირაობა?: ");
        int rentDays = SharedUtils.ParseStringToInt(Console.ReadLine());

       
        int totalPayment = Calculator.Multiply(rentDays, pricePerDay);
        int totalPaymentWithInsurance = Calculator.Add(totalPayment, insurancePrice);
        Car car = new Car(inputModel, carYear, pricePerDay, rentDays);
        
        Console.WriteLine("შეკვეთის დეტალები");
        car.ShowRentalDetails();
        
        currentStatus = StatusesEnum.Approved;
        Console.WriteLine($"მანქანის თანხა {totalPayment} ლარი status = {currentStatus}");
        
        Console.WriteLine($"მანქანის ფასი დაზღვვევით {totalPaymentWithInsurance} ლარი. დაზვევა სავალდებულოა");
        
        
    }
    
}