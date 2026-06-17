namespace FitnessApp.PartialClasses;

public partial class Customers
{
    public string Name { get; set; }
    public int Age { get; set; }

    partial void ShowMessage();

    public void Display()
    {
        ShowMessage();
    }
}