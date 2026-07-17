namespace Assigment_10.Data;

public class Students
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name}, {Age}";
    }
}