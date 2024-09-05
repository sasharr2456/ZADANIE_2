using ConsoleApp1;
using System;


public class Shop
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowProducts()
    {
        foreach (var product in products)
        {
            Console.WriteLine(product.GetInformation());
        }
    }

    public void ApplyDiscount(decimal discountPercentage)
    {
        foreach (var product in products)
        {
            product.Price -= product.Price * (discountPercentage / 100);
        }
    }
}




class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();

        Toy toy = new Toy { Name = "Трансформер", ToyType = "Машина", Price = 1500 };
        Meat meat = new Meat { Name = "Говядина", Weight = 1.5m, Price = 400 };
        Drink drink = new Drink { Name = "Сок", Volume = "1 литр", Price = 150 };
        Electronics electronics = new Electronics { Name = "Смартфон", WarrantyPeriod = 2, Price = 30000 };
       

        shop.AddProduct(toy);
        shop.AddProduct(meat);
        shop.AddProduct(drink);
        shop.AddProduct(electronics);
        

        Console.WriteLine("Продукты в магазине:");
        shop.ShowProducts();

        shop.ApplyDiscount(10);
        Console.WriteLine("\nПосле применения скидки:");
        shop.ShowProducts();
    }
}