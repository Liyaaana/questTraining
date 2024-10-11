using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertCase
{
    internal class Program

    {
        static void ConvertCase(string text, bool toLower = false)
        {
            Console.WriteLine(toLower ? text.ToLower() : text.ToUpper());
        }
        static void Main(string[] args)
        {
            ConvertCase("Hello");
            ConvertCase("Hello", true);
        }
    }
}

