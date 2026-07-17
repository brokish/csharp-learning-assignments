namespace Assigment9_library.Services;

public class Students
{
    public void StudentList(string name1, string name2, string name3, string name4, string name5)
    {
        var students = new List<string>();

        students.Add(name1);
        students.Add(name2);
        students.Add(name3);
        students.Add(name4);
        students.Add(name5);


        Console.WriteLine("შეყვანილი სტუდენტების სია არის : ");
        foreach (var listOfStudents in students) Console.WriteLine(listOfStudents);
        Console.WriteLine("სტუდენტების რაოდენობა არის : ");
        Console.WriteLine(students.Count);


        students.RemoveAt(2);
        Console.WriteLine("განახლებული სტუდენტების სია არის : ");
        foreach (var student in students) Console.WriteLine(student);
    }

    public (string Name, int Age, double AverageGrade) StudentTuple(string name, int age, double averageGrade)
    {
        var student = (Name: name, Age: age, AverageGrade: averageGrade);

        Console.WriteLine($"სტუდენტის სახელია ; {student.Name}");
        Console.WriteLine($"სტუდენტის ასაკია ; {student.Age}");
        Console.WriteLine($"სტუდენტის საშუალო ქულა ; {student.AverageGrade}");

        Console.WriteLine("Student Information Completed.");

        return student;
    }
}