using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creditcard2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cc = new CreditCard()
            {
                CardNumber = 1345667677,
                ExpiryMonth = 1,
                ExpiryYear = 2034,
                Cvc = 123
            };
            Console.WriteLine(cc.ToString());
        }
    }
}
