namespace Assigment_10.MainAppLogics;
using Homework.Helpers;

public class UserApp
{
    
    
    public void ShowUser(dynamic user)
    {
        Console.WriteLine($"Name: {user.Name}");
        
        try { Console.WriteLine($"Age: {user.Age}"); } catch { }
        try { Console.WriteLine($"City: {user.City}"); } catch { }
        try { Console.WriteLine($"Email: {user.Email}"); } catch { }
        try { Console.WriteLine($"IsActive: {user.IsActive}"); } catch { }
    }
    public void Run()
    {
        Console.WriteLine("=== პირველი მომხმარებლის მონაცემები ===");
    
        Console.Write("შეიყვანეთ სახელი: ");
        string name = Console.ReadLine();
    
        Console.Write("შეიყვანეთ ასაკი: ");
        int age = SharedUtils.ParseStringToInt(Console.ReadLine());
    
        Console.Write("შეიყვანეთ ქალაქი: ");
        string city = Console.ReadLine();
    
        dynamic user1 = new { Name = name, Age = age, City = city };

        Console.WriteLine("\n=== მეორე მომხმარებლის მონაცემები ===");
    
        Console.Write("შეიყვანეთ სახელი: ");
        string name1 = Console.ReadLine();
    
        Console.Write("შეიყვანეთ იმეილი: ");
        string email1 = Console.ReadLine();
    
        Console.Write("აქტიურია თუ არა (true/false): ");
        bool isActive = bool.Parse(Console.ReadLine());
    
        dynamic user2 = new { Name = name1, Email = email1, IsActive = isActive };

        List<dynamic> dynamicList = new List<dynamic>();
        dynamicList.Add(user1);
        dynamicList.Add(user2);
        dynamicList.Add("უბრალოდ ტექსტური მნიშვნელობა"); 
        dynamicList.Add(2026);                         

        Console.WriteLine("\n-------------------------\n");
    
        Console.WriteLine("User 1:");
        ShowUser(user1);

        Console.WriteLine("\nUser 2:");
        ShowUser(user2);
    }
}