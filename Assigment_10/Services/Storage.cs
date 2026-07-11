namespace Assigment_10.Services;

public class Storage<T>
{
   private List<T> items = new List<T>();

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
      foreach (var VARIABLE in items)
      {
         Console.WriteLine(VARIABLE);
      }
   }

}