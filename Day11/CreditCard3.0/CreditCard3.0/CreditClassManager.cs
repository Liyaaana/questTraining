using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard3._0
{
    /// <summary>
    /// This class is responsible for managing the credit cards.
    /// </summary>
    class CreditCardManager
    {
        private List<CreditCard> creditCards = new List<CreditCard>();

        /// <summary>
        /// This method adds a credit card. If a credit card already exists, it will not be added.
        /// </summary>
        /// <param name="card">An instance of <see cref="CreditCard"/>>.</param>
        public void Add(CreditCard card)
        {
            // Check if the same card exists.
            foreach (var item in creditCards)
            {
                if (item.CardNumber == card.CardNumber)
                {
                    Console.WriteLine("Card already exists");
                    return;
                }
            }

            creditCards.Add(card);
            Console.WriteLine("Added successfully");
        }

        /// <summary>
        /// This method searches for a credit card based on the card number.
        /// </summary>
        /// <param name="cardNumber">The credit card number.</param>
        public void Search(string cardNumber)
        {
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    Console.WriteLine(card);
                }
            }
        }

        public void Update(string cardNumber, string cardHolderName, string expiry, int securityCode)
        {
            var card = GetCardByNumber(cardNumber);
            if (card == null)
            {
                Console.WriteLine("Card not found");
                return;
            }

            card.Expiry = expiry;
            card.CardHolderName = cardHolderName;
            card.SecurityCode = securityCode;
            Console.WriteLine("Updated successfully");
        }

        public void Delete(string cardNumber)
        {
            var card = GetCardByNumber(cardNumber);
            if (card == null)
            {
                Console.WriteLine("Card not found");
                return;
            }

            creditCards.Remove(card);
            Console.WriteLine("Deleted successfully");
        }

        private CreditCard GetCardByNumber(string cardNumber)
        {
            // Check if the same card exists.
            foreach (var card in creditCards)
            {
                if (card.CardNumber == cardNumber)
                {
                    return card;
                }
            }
            return null;
        }
    }
}
