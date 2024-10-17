using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard3._0
{
    class CreditCard
    {
        public string CardHolderName;
        public string CardNumber;
        public string Expiry;
        public int SecurityCode;

        public override string ToString()
        {
            return $"CardHolderName: {CardHolderName}, CardNumber: {CardNumber}, Expiry: {Expiry}, SecurityCode: {SecurityCode}";
        }
    }
}
