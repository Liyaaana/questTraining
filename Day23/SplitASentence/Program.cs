using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello,World! Welcome to the world of Python programming.";
            char[] delimeters = { ' ', ',', '!', '.' };
            string[] words = input.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);//prevents empty strings, which can happen if there are consecutive delimiters.
            int count = words.Length; 
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("count=" + count);

        }
    }
}
