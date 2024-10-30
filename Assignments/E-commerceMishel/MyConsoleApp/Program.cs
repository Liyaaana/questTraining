using System;
using System.Data.SqlClient;
using System.Threading;

namespace MyConsoleApp
{
    // class DiscountStrategy
    // {
    //     public decimal ApplyDiscount(decimal totalPrice, string strategy)
    //     {
    //         if (strategy == "percentage")
    //         {
    //             return totalPrice - (totalPrice * 2 / 100);
    //         }
    //         else if(strategy == "flat")
    //         {
    //             return totalPrice - 200;
    //         }
    //     }
    // }
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.Add(new CartItem { Name = "Item 1", Price = 100, Quantity = 2 });
            cart.Add(new CartItem { Name = "Item 2", Price = 200, Quantity = 3 });
            cart.Add(new CartItem { Name = "Item 3", Price = 300, Quantity = 4 });
            
            var discountStrategy = new PercentageDiscountStrategy();
            var billingService = new BillingService(discountStrategy);
            var totalAmount = billingService.CalculateTotalAmount(cart.GetAll());
            Console.WriteLine($"Total amount: {totalAmount}");
        }
    }
}
