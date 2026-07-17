namespace Assigment9_library.Data;

public class StudentData
{
    public Dictionary<int, string> StudentInfo()
    {
        var listOfStudents = new Dictionary<int, string>();

        listOfStudents.Add(101, "Maka");
        listOfStudents.Add(102, "Lika");
        listOfStudents.Add(103, "Ana");
        listOfStudents.Add(104, "Luka");

        return listOfStudents;
    }
}