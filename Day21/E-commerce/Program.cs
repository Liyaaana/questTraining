using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
E-commerce Cart Management System
Scenario: You're developing a shopping cart feature for an e-commerce platform.
Questions:
Design a Cart class that allows items to be added, updated, and removed. Each item has a name, quantity, and price.
Challenge: Ensure the Cart class follows the Single Responsibility Principle (SRP) by separating the cart’s functionality from the billing calculations.
Implement a discount system for the cart that allows adding different discount strategies (percentage-based, flat discount, buy-one-get-one).
Challenge: Use the Open/Closed Principle (OCP) to ensure that you can add new discount types without modifying existing code.
*/
namespace E_commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.Add(new CartItem("Colgate", 70, 45));
            cart.Add(new CartItem("Product 2", 16, 780));
            cart.Add(new CartItem("Product 3", 10, 80));

            cart.Update("Colgate", 77, 50);
            cart.Remove("Product 3");

            var bill = new Billing();
            var discount = new PercentageDiscount();
            decimal billValue = bill.TotalPrice(cart, discount);
            Console.WriteLine(billValue);
        }
    }
}
