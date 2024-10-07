using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string text = "MALAYALAM";
            // string.Concat method is used to join the characters of the reversed string text.Reverse() into a single string.
            var reverse = string.Concat(text.Reverse());
            if (text == reverse)
            {
                Console.WriteLine("same ");
            }
        }
    }
}
