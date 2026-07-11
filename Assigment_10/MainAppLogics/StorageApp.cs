using Assigment_10.Services;
using Assigment_10.Data;
namespace Assigment_10.MainAppLogics;
using Homework.Helpers;


public class StorageApp
{
    public void Run()
    {
        var studentStorage = new Storage<Students>();
        Console.WriteLine("შეიყვანეთ სტუდენტის აიდი , სახელი და ასაკი");
        
        int id = SharedUtils.ParseStringToInt(Console.ReadLine());
        string name = Console.ReadLine();
        int age = SharedUtils.ParseStringToInt(Console.ReadLine());
        
        var newStudent = new Students()
        {
            ID = id,
            Name = name,
            Age = age
        };
        studentStorage.AddItem(newStudent);
      
        var nameStorage = new Storage<string>();
        nameStorage.AddItem("shota");

        nameStorage.AddItem("giorgi");

        nameStorage.AddItem("irakli");
       
        studentStorage.ShowAllElemnts(); 
        nameStorage.ShowAllElemnts();
    }
}