using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
        }
    }
}
public class Product
{
    public ProductName name;
    public int price;
}
public class Payment
{
    public int currentMoney; 
    public void MinusMoney(int needToPay)
    {
        currentMoney -= needToPay;
    }
}
class Cash : Payment
{

}
class NonCash : Payment
{

}
public class Shop
{
    List<Product> products = new List<Product> { };
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public bool CheckProduct(Product product)
    {
        foreach (Product item in products)
        {
            if (item.name == product.name)
            {
                return true;
            }
        }
        return false;
    }
    public void ShowProducts()
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"Название : {product.name}, Цена :{product.price} ");
        }
    }
    public void BuyProduct(Product product, Payment payment)
    {
        if (CheckProduct(product) == true)
        {
            if (payment.currentMoney <= product.price)
            {
                Console.WriteLine("Not enough money");
            }
            else
            {
                payment.MinusMoney(product.price);
            }       
        }
        else
        {
            Console.WriteLine("Out of stock");
        }
    }

}
public enum ProductName
{
    Orange,
    Strawberry,
    Milk,
    Flour,
    Pineapple
}