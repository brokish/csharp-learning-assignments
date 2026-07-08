using Assigment9_library.Data;
using Assigment9_library.Services;
using Homework.Helpers;

namespace Assigment9_library.MainProgram;



public class MainLogics
{
    Students student = new Students();
    private StudentData studentData = new StudentData();
    BookData  books = new BookData();
    
    public void studentAppRunner()
    {
        Console.WriteLine("გთხოვთ შეიყვანოთ 5 სტუდენტის სახელი:");
        string name1 = Console.ReadLine();
        string name2 = Console.ReadLine();
        string name3 = Console.ReadLine();
        string name4 = Console.ReadLine();
        string name5 = Console.ReadLine();
        
        
        student.StudentList(name1, name2, name3, name4, name5);
    }

    public void searchStudents()
    {
        Console.WriteLine("გთხოვთ შეიყვანოთ სტუდენტის ID, რომლის მოძებნაც გსურთ: გიბეჭდავთ სტუდენტების სიას"); 
        foreach (var name in studentData.StudentInfo().Values)
        {
            Console.WriteLine(name);
        }
        
        int id  = SharedUtils.ParseStringToInt(Console.ReadLine());
        
        
        if (studentData.StudentInfo().ContainsKey(id) == true) 
        {
            Console.WriteLine($"სტუდენტი ნაპოვნია: {studentData.StudentInfo()[id]}");
        }
        
        else
        {
            Console.WriteLine("სტუდენტი ვერ მოიძებნა");
        }
    }

    public void BookDictionary()
    {
        Stack<string> myBooks = books.BookList();

        Console.WriteLine($"ვბეჭდავ ზედა ელემენტის -  {myBooks.Peek()}");

        myBooks.Pop();

        Console.WriteLine($"ვბეჭდავ ახალ ზედა ელემენტს -  {myBooks.Peek()}");

        Console.WriteLine($"რაოდენობა- {myBooks.Count}");
    }

    public void TupleAppRunner()
    {

        Console.WriteLine("შეიყვანეთ სახელი");
        string name = Console.ReadLine();
        
        Console.WriteLine("შეიყვანეთ ასაკი");
        int age =  SharedUtils.ParseStringToInt(Console.ReadLine());
        
        Console.WriteLine("შეიყვანეთ საშუალო ქულა");
        double avarageGrade =  SharedUtils.ParseStringToDouble(Console.ReadLine());
        
        student.StudentTuple(name, age, avarageGrade);
        
        Console.WriteLine();
    }
    
    
}