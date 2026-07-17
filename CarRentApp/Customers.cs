namespace CarRentApp;

public class Customers
{
    public int Age;
    public string Name;
    public string Surname;


    public Customers(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public void ShowClientInfo()
    {
        Console.WriteLine($"კლიენტის სახელი და გვარი: {Name} {Surname}");
        Console.WriteLine($"ასაკი: {Age} წლის");
    }
}