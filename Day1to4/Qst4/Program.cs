using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This is really long long text";
            string[] words = text.Split(' ');
            string[] wordsFound = new string[words.Length];
            int wordsCheckedCount = 0;
            foreach (var word in words)
            {
                int count = 0;
                string word = words[i];
                foreach (var item in words)
                {
                    if (words == word)
                    {
                        count++;

                    }
                }
                wordsFound[wordsCheckedCount] = word;
                wordsChecked++;
                Console.WriteLine($"{words}: {count}");

            }
        }

    }
}
