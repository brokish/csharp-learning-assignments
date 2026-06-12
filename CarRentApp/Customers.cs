namespace CarRentApp;

public class Customers
{
    public int Age;
    public string Name;
    public string Surname;
    
    
    public Customers(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    
    public void ShowClientInfo()
    {
        Console.WriteLine($"კლიენტის სახელი და გვარი: {Name} {Surname}");
        Console.WriteLine($"ასაკი: {Age} წლის");
    }
}