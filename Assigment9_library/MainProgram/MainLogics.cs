using Assigment9_library.Data;
using Assigment9_library.Services;
using Homework.Helpers;

namespace Assigment9_library.MainProgram;

public class MainLogics
{
    private readonly BookData books = new();
    private readonly Students student = new();
    private readonly StudentData studentData = new();

    public void studentAppRunner()
    {
        Console.WriteLine("გთხოვთ შეიყვანოთ 5 სტუდენტის სახელი:");
        var name1 = Console.ReadLine();
        var name2 = Console.ReadLine();
        var name3 = Console.ReadLine();
        var name4 = Console.ReadLine();
        var name5 = Console.ReadLine();


        student.StudentList(name1, name2, name3, name4, name5);
    }

    public void searchStudents()
    {
        Console.WriteLine("გთხოვთ შეიყვანოთ სტუდენტის ID, რომლის მოძებნაც გსურთ: გიბეჭდავთ სტუდენტების სიას");
        foreach (var name in studentData.StudentInfo().Values) Console.WriteLine(name);

        var id = SharedUtils.ParseStringToInt(Console.ReadLine());


        if (studentData.StudentInfo().ContainsKey(id))
            Console.WriteLine($"სტუდენტი ნაპოვნია: {studentData.StudentInfo()[id]}");

        else
            Console.WriteLine("სტუდენტი ვერ მოიძებნა");
    }

    public void BookDictionary()
    {
        var myBooks = books.BookList();

        Console.WriteLine($"ვბეჭდავ ზედა ელემენტის -  {myBooks.Peek()}");

        myBooks.Pop();

        Console.WriteLine($"ვბეჭდავ ახალ ზედა ელემენტს -  {myBooks.Peek()}");

        Console.WriteLine($"რაოდენობა- {myBooks.Count}");
    }

    public void TupleAppRunner()
    {
        Console.WriteLine("შეიყვანეთ სახელი");
        var name = Console.ReadLine();

        Console.WriteLine("შეიყვანეთ ასაკი");
        var age = SharedUtils.ParseStringToInt(Console.ReadLine());

        Console.WriteLine("შეიყვანეთ საშუალო ქულა");
        var avarageGrade = SharedUtils.ParseStringToDouble(Console.ReadLine());

        student.StudentTuple(name, age, avarageGrade);

        Console.WriteLine();
    }
}