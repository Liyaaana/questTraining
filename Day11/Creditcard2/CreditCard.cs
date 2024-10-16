using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creditcard2
{
    public class CreditCard
    {
        public long CardNumber;
        public byte ExpiryMonth;
        public int ExpiryYear;
        public int Cvc;

        public override string ToString()
        {
            return $"Number: {CardNumber}, Expiry: {ExpiryMonth}/{ExpiryYear}, CVC: {Cvc}";
        }
    }
}
