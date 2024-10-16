using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard3
{
    internal class Credit
    {
        private List<CreditCard> creditCards = new List<CreditCard>();

        public class CreditCard
        {
            public int CardNumber;
            public int ExpiryMonth;
            public int ExpiryYear;
            public int CVC;

            public CreditCard(int cardNumber, int expiryMonth, int expiryYear, int cvc)
            {
                CardNumber = cardNumber;
                ExpiryMonth = expiryMonth;
                ExpiryYear = expiryYear;
                CVC = cvc;
            }

            public void Display()
            {
                Console.WriteLine($"Card Number: {CardNumber}, Expiry: {ExpiryMonth}/{ExpiryYear}, CVC: {CVC}");
            }
        }
        public void AddCreditCard(int cardNumber, int expiryMonth, int expiryYear, int cvc)
        {
            creditCards.Add(new CreditCard(cardNumber, expiryMonth, expiryYear, cvc));
            Console.WriteLine("Added successfully.");
        }

        public void UpdateCreditCard(int cardNumber, int newExpiryMonth, int newExpiryYear, int newCVC)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    card.ExpiryMonth = newExpiryMonth;
                    card.ExpiryYear = newExpiryYear;
                    card.CVC = newCVC;
                    Console.WriteLine("Updated successfully.");
                    return;
                }
            }
            Console.WriteLine("Not found.");
        }

        public void DeleteCreditCard(int cardNumber)
        {
            for (int i = 0; i < creditCards.Count; i++)
            {
                if (creditCards[i].CardNumber == cardNumber)
                {
                    creditCards.RemoveAt(i);
                    Console.WriteLine("Deleted successfully.");
                    return;
                }
            }
            Console.WriteLine("Not found.");
        }

        public void SearchCreditCard(int cardNumber)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    card.Display();
                    return;
                }
            }
            Console.WriteLine("Credit card not found.");
        }
    }
}
