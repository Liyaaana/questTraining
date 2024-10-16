using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creditcard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cc = new CreditCard();
            Console.WriteLine("enter the card number: ");
            cc.CardNo = int.Parse(Console.ReadLine());
            Console.WriteLine("enter expiry: ");
            cc.Expiry = Console.ReadLine();
            Console.WriteLine("enter Cvc: ");
            cc.Cvc = int.Parse(Console.ReadLine());
        }
    }
}
