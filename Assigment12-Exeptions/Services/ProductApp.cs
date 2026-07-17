using Assigment12_Exeptions.Data;
using Assigment12_Exeptions.Exeptions;

namespace Assigment12_Exeptions.MainApplication;

public class ProductApp
{
    public List<Product> productList = new();

    public void AddProduct(Product product)
    {
        if (product.Price <= 0) throw new InvalidPriceException("ფასი არუნდა იყოს 0 ზე ნაკლები");

        productList.Add(product);
        Console.WriteLine("პროდუქტი წარმატებით დაემატა კალათაში");
    }

    public void RunProductApp()
    {
        var product1 = new Product { Id = 1, ProductName = "Macbook m4 pro", Price = 9800 };
        var product2 = new Product { Id = 2, ProductName = "Iphone 17 pro max", Price = 4000 };
        var product3 = new Product { Id = 3, ProductName = "Razer Mouse", Price = 150 };
        var product4 = new Product { Id = 4, ProductName = "Razer Keyboard", Price = 500 };

        try
        {
            AddProduct(product1);
        }
        catch
            (InvalidPriceException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            AddProduct(product2);
        }
        catch (InvalidPriceException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            AddProduct(product3);
        }
        catch (InvalidPriceException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            AddProduct(product4);
        }
        catch (InvalidPriceException ex)
        {
            Console.WriteLine(ex.Message);
        }


        Console.WriteLine("პროდუქტების სია:");
        foreach (var prod in productList) Console.WriteLine($"{prod.ProductName} - {prod.Price}");
    }
}