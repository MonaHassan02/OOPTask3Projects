using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" E-Commerce System");
           
            User user = SelectUserType();

            Console.WriteLine(" Enter Product Details:");
            decimal price = GetInput("Product Price: $", 0.01m, 10000m);
            int quantity = (int)GetInput("Quantity: ", 1, 1000);


            Discount discount = user.GetDiscount();
            decimal subtotal = price * quantity;
            decimal discountAmount = discount.CalculateDiscount(price, quantity);
            decimal finalPrice = subtotal - discountAmount;

            ShowReceipt(user, price, quantity, discount, subtotal, discountAmount, finalPrice);

            Console.ReadLine();
        }

        static User SelectUserType()
        {
            Console.WriteLine("\n Select User Type:");
            Console.WriteLine("1. Regular User (5% discount)");
            Console.WriteLine("2. Premium User ($100 flat discount)");
            Console.WriteLine("3. Guest User (No discount)");

            while (true)
            {
                Console.Write("Choose 1-3: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter your name: ");
                        return new RegularUser(Console.ReadLine());

                    case "2":
                        Console.Write("Enter your name: ");
                        return new PremiumUser(Console.ReadLine());

                    case "3":
                        return new GuestUser();

                    default:
                        Console.WriteLine(" Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static decimal GetInput(string prompt, decimal min, decimal max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out decimal value) && value >= min && value <= max)
                    return value;

                Console.WriteLine($" Please enter a value between {min} and {max}");
            }
        }

        static void ShowReceipt(User user, decimal price, int quantity, Discount discount,
                               decimal subtotal, decimal discountAmount, decimal finalPrice)
        {
            Console.WriteLine("\n" + new string('═', 40));
            Console.WriteLine("RECEIPT");
            Console.WriteLine(new string('═', 40));

            Console.WriteLine($"User: {user.Name} ({user.GetType().Name})");
            Console.WriteLine($"Discount: {discount.Name}");
            Console.WriteLine($"Price: {price:C} × {quantity} = {subtotal:C}");

            Console.WriteLine(new string('─', 40));
            Console.WriteLine($"Discount: -{discountAmount:C}");
            Console.WriteLine($"Total: {finalPrice:C}");
            Console.WriteLine(new string('═', 40));
        
    }
    }
}
