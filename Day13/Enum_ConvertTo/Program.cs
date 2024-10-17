using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_ConvertTo
{
    internal class Program
    {
        public enum ConvertTo
        {
            Upper,
            Lower,
            SwapCase
        }

        public static void ConvertCasing(string input, ConvertTo targetType)
        {
            switch (targetType)
            {
                case ConvertTo.Upper:
                    Console.WriteLine(input.ToUpper());
                    break;
                case ConvertTo.Lower:
                    Console.WriteLine(input.ToLower());
                    break;
            }
        }
        static void Main(string[] args)
        {
            ConvertCasing("Hello", ConvertTo.SwapCase);
        }
    }
}
