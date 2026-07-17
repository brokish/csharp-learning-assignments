namespace Assigment_10.Services;

public class Storage<T>
{
    private readonly List<T> items = new();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void RemoveItem(T item)
    {
        items.Remove(item);
    }

    public void ShowAllElemnts()
    {
        foreach (var VARIABLE in items) Console.WriteLine(VARIABLE);
    }
}