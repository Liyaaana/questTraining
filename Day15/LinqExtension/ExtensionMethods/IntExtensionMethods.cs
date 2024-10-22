using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExtension.ExtensionMethods
{
    internal static class IntExtensionMethods
    {
        public static bool IsEvenOrOdd(this int num)
        {
            if (num % 2 == 0)
            {
                return true; ;
            }
            else
            {
                return false;
            }
        }
    }
}
