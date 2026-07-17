using Assigment_10.Data;
using Assigment_10.Services;
using Homework.Helpers;

namespace Assigment_10.MainAppLogics;

public class StorageApp
{
    public void Run()
    {
        var studentStorage = new Storage<Students>();
        Console.WriteLine("შეიყვანეთ სტუდენტის აიდი , სახელი და ასაკი");

        var id = SharedUtils.ParseStringToInt(Console.ReadLine());
        var name = Console.ReadLine();
        var age = SharedUtils.ParseStringToInt(Console.ReadLine());

        var newStudent = new Students
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