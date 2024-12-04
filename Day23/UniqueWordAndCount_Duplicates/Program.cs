using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueWordAndCount_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string input = "Hello,World! Welcome to the world of Python programming.";
            char[] delimeters = { ' ', ',', '!', '.' };
            string[] words = input.ToLower().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);//prevents displaying empty strings, which can happen if there are consecutive delimiters like !space.
            /*
            // To print unique words
            string input = "Hello,World! Welcome to the world of Python programming.";
            char[] delimeters = { ' ', ',', '!', '.' };
            string[] words = input.ToLower().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> uniqueWords = new HashSet<string>(words);
            Console.WriteLine($"Unique words: {string.Join(",", uniqueWords)}");  
            Console.WriteLine("Count of unique words=" + uniqueWords.Count);
            */

            /*
            // To print word and count using LINQ
            string input = "Hello,World! Welcome to the world of Python programming.";
            char[] delimeters = { ' ', ',', '!', '.' };
            string[] words = input.ToLower().Split(delimeters, StringSplitOptions.RemoveEmptyEntries)
                                  .GroupBy(x => x);
            foreach (var group in result)
            {
                Console.WriteLine(group.Key + " " + group.Count());
            }
            */

            // To print word and count normal using dictionary
            Dictionary<string, int> wordAndCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordAndCount.ContainsKey(word))
                {
                    wordAndCount[word]++;//increment the value of key
                }
                else
                {
                    wordAndCount[word] = 1;
                }
            }
            foreach (var item in wordAndCount)
            {
                Console.WriteLine($"Word : {item.Key}, Count : {item.Value}");

            }
            //not Console.WriteLine("Unique words: " + wordCount.Key);
            Console.WriteLine("Unique words: " + string.Join(", ",wordAndCount.Keys));
            Console.WriteLine("Total unique words: " + wordAndCount.Count);

        }
    }
}
