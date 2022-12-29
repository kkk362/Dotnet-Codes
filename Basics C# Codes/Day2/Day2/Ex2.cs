using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Product Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Product Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Product Cost");
            double cost = double.Parse(Console.ReadLine());
            Product product = new Product(id,name,cost);
            product.Display();
          string str=  product.Display1();
            Console.WriteLine(str);

            Console.WriteLine(product);// how to override .ToString Method in C#.net

            
           
        }
    }
    class Product
    {
        int ProductId;
        string ProductName;
        double ProductCost;
        public Product() { }

        public Product(int productId, string productName, double productCost)
        {
            ProductId = productId;
            ProductName = productName;
            ProductCost = productCost;
        }
        public void Display()
        {
            Console.WriteLine("Id={0} Name={1} Cost={2}",ProductId,ProductName,ProductCost);
        }
        public string Display1()
        {
               return string.Format ("Id={0} Name={1} Cost={2}", ProductId, ProductName, ProductCost);
        }
        public override string ToString()
        {
           return string.Format("Id={0} Name={1} Cost={2}", ProductId, ProductName, ProductCost);
        }

    }
}
