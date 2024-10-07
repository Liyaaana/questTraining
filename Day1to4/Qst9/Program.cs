using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "HeLlO WoRlD";
            string s = "";

            foreach (var chr in text)
            {
                char res = char.IsUpper(chr) ? char.ToLower(chr) : char.ToUpper(chr);
                s = s + res;
            }

            Console.WriteLine(s);
        }
    }
}
