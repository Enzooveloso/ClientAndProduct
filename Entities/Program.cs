using System;
using System.Globalization;
using compAndEnum.Entities.Enums;
using compAndEnum.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth data(DD/MM/YYYY):");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, data);
            

            Console.WriteLine("Enter order data:");
            Console.Write("Status:");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status,client);

            Console.Write("How many  items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data: ");
                Console.WriteLine("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Procust price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(quantity, price, product);

                order.addItem(item);
            }

            Console.WriteLine("\nORDER SUMMARY");
            Console.WriteLine(order);
        }
    }
}