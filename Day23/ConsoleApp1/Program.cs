using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicateWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello,World! Welcome to the world of Python programming.";
            char[] delimeters = { ' ', ',', '!', '.' };
            string[] words = input.ToLower().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> uniqueWords = new HashSet<string>(words);
            string result = string.Join(",", uniqueWords);
            Console.WriteLine("String without duplicates: " + result);
        }
    }
}
