using Assigment_10.Data;
using Homework.Helpers;

namespace Assigment_10.MainAppLogics;

public class StudentReporter
{
    public void Run()
    {
        var student = new List<Student>();

        Console.WriteLine("შეიყვანეთ სტუდენტის სახელი");
        var studentName = Console.ReadLine();

        Console.WriteLine("შეიყვანეთ სტუდენტის ასაკი");
        var studentAge = SharedUtils.ParseStringToInt(Console.ReadLine());

        Console.WriteLine("შეიყვანეთ სტუდენტის ფაკულტეტი");
        var studentFaculty = Console.ReadLine();

        Console.WriteLine("შეიყვანეთ სტუდენტის ქულა");
        var studentScore = SharedUtils.ParseStringToDouble(Console.ReadLine());

        student.Add(
            new Student { name = studentName, age = studentAge, faculty = studentFaculty, score = studentScore });

        Console.WriteLine("სტუდენტის სახელი: " + student[0].name);
        Console.WriteLine("სტუდენტის ასაკი: " + student[0].age);
        Console.WriteLine("სტუდენტის ფაკულტეტი: " + student[0].faculty);

        var info = new
        {
            Name = student[0].name,
            Faculty = student[0].faculty
        };

        var reportInfo = new
        {
            Name = student[0].name,
            Score = student[0].score,
            Status = student[0].score >= 50 ? "passed" : "failed"
        };

        Console.WriteLine("students:");
        Console.WriteLine($"{info.Name} - {info.Faculty}");

        Console.WriteLine("Results:");
        Console.WriteLine(reportInfo.Name);
        Console.WriteLine($"Score: {reportInfo.Score}");
        Console.WriteLine($"Status: {reportInfo.Status}");
    }
}