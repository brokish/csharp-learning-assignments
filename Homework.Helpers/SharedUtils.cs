namespace Homework.Helpers;

public class SharedUtils
{
    public static void InitializeConsole()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
    }

    public static int ParseStringToInt(string? input)
    {
        while (string.IsNullOrEmpty(input) || !int.TryParse(input, out _))
        {
            Console.WriteLine("ტექსტის რიცხვად გარდაქმნა ვერ მოხერხდა. სცადეთ ახლიდან:");
            input = Console.ReadLine();
        }
        return int.Parse(input);
    }
}