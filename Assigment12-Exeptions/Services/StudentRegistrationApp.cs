using Assigment12_Exeptions.Data;
using Assigment12_Exeptions.Exeptions;
using Homework.Helpers;

namespace Assigment12_Exeptions.MainApplication;

public class StudentRegistrationApp
{
    private readonly List<Student> studentList = new();
    private Student student = new();

    public void Registration()
    {
        Console.WriteLine("შეიყვანეთ სახელი:");
        var name = Console.ReadLine();
        Console.WriteLine("შეიყვანეთ ასაკი:");
        var age = SharedUtils.ParseStringToInt(Console.ReadLine());

        if (age < 18) throw new InvalidAgeException("18 წლამდე ასაკის სტუდენტების რეგისტრაცია აკრძალულია.");

        Console.WriteLine("შეიყვანეთ თქვენი ID:");
        var id = SharedUtils.ParseStringToInt(Console.ReadLine());

        Console.WriteLine("ჩაწერეთ რა თანხის შეტანა გსურთ: ");
        var initialBalance =
            SharedUtils.ParseStringToDouble(Console
                .ReadLine()); // დეციმალის ვალიდაციის დამატება ვეღარ მოვასწარი და დაბლში მაგიტომაა

        Console.WriteLine("შეიყვანეთ ბანკის ანგარიშის ნომერი:");
        var accNumber = Console.ReadLine();


        var newStudent = new Student();

        newStudent.Name = name;
        newStudent.Age = age;
        newStudent.ID = id;

        newStudent.Account = new BankAccount
        {
            AccountNumber = accNumber,
            OwnerName = name,
            Balance = initialBalance
        };
        studentList.Add(newStudent);


        Console.WriteLine($"სახელი: {name} ");
        Console.WriteLine($"ასაკი: {age}");
        Console.WriteLine($"საიდენტიფიკაციო ნომერი: {id}");

        Console.WriteLine("შეიყვანეთ რა თანხის გატანა გსურთ :");
        var withdrawAmount = SharedUtils.ParseStringToDouble(Console.ReadLine());

        try
        {
            newStudent.Account.WithdrawAmount(withdrawAmount);
            Console.WriteLine($"ბალანსი წარმატებით შეივსო! ნაშთი : {newStudent.Account.Balance}");
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine($" Error: {ex.Message}");
        }
    }

    public void StudentRegistration()
    {
        var reg = true;

        while (reg)
        {
            try
            {
                Registration();
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("თუ გსურთ თავიდან დავიწყოთ პროცესი შეიყვანეთ true თუ არადა false");
            reg = Console.ReadLine() == "true";
        }
    }
}