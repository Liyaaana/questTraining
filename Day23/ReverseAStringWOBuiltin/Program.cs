using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAStringWOBuiltin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            Console.WriteLine(result);
        }
    }
}
