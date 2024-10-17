using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new Credit();

            while (true)
            {
                Console.WriteLine("1. Add credit card");
                Console.WriteLine("2. Search credit card by number");
                Console.WriteLine("3. Update credit card details");
                Console.WriteLine("4. Delete credit card");
                Console.WriteLine("5. Exit");
                var c = Console.ReadLine();

                switch (c)
                {
                    case "1":
                        AddCreditCard(user);
                        break;
                    case "2":
                        SearchCreditCard(user);
                        break;
                    case "3":
                        UpdateCreditCard(user);
                        break;
                    case "4":
                        DeleteCreditCard(user);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("INVALID");
                        break;
                }
            }
        }

        static void AddCreditCard(Credit user)   
        {
            // AddCreditCard method prompts the user to input credit card details, then calls the AddCreditCard method of the Credit class.
            Console.WriteLine("Enter the card number:");
            int cardNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the expiry month in MM");
            int expiryMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the expiry year in YY");
            int expiryYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the CVC");
            int cvc = int.Parse(Console.ReadLine());

            user.AddCreditCard(cardNumber, expiryMonth, expiryYear, cvc);
        }

        static void SearchCreditCard(Credit user)
        {
            Console.WriteLine("Enter the card number:");
            int cardNumber = int.Parse(Console.ReadLine());

            user.SearchCreditCard(cardNumber);
        }

        static void UpdateCreditCard(Credit user)
        {
            Console.WriteLine("Enter the card number to update:");
            int cardNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new expiry month (MM):");
            int newExpiryMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new expiry year (YY):");
            int newExpiryYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new CVC:");
            int newCVC = int.Parse(Console.ReadLine());

            user.UpdateCreditCard(cardNumber, newExpiryMonth, newExpiryYear, newCVC);
        }

        static void DeleteCreditCard(Credit user)
        {
            Console.WriteLine("Enter the card number to delete:");
            int cardNumber = int.Parse(Console.ReadLine());

            user.DeleteCreditCard(cardNumber);
        }
    }
}
