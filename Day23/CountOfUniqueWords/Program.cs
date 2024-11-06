using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueWordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello,World! Welcome to the world of Python programming.";
            char[] delimeters = { ' ', ',', '!', '.' };
            string[] words = input.ToLower().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);//to remove empty entries, which can happen if there are consecutive delimiters.
            HashSet<string> uniqueWords = new HashSet<string>(words);
            int uniqueCount = uniqueWords.Count;
            Console.WriteLine("Unique words:");
            foreach (string word in uniqueWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Unique Count of words=" + uniqueCount);
        }
    }
}
/*
string text = "Hello all how are you all";
 var result = text.ToLower()
     .Split(' ')
     .GroupBy(x => x);
 foreach (var group in result)
 {
     Console.WriteLine(group.Key +" "+ group.Count());
 }
*/
/*
namespace UniqueWordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello, World! Welcome to the world of Python programming. Hello world!";

            // Split the input string into words using delimiters and remove empty entries
            char[] delimiters = { ' ', ',', '!', '.', '?' };
            string[] words = input.ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Use a Dictionary to store the count of each unique word
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Count occurrences of each word
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            // Print each unique word and its count
            Console.WriteLine("Unique words and their counts:");
            foreach (var entry in wordCount)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            // Print the total count of unique words
            Console.WriteLine("Total unique words: " + wordCount.Count);
        }
    }
}
*/