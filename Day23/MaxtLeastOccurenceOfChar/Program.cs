using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxtLeastOccurenceOfChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello, World! Welcome to the world of Python programming.";
            var characterGroups = input
                .Where(c => char.IsLetter(c)) 
                .Select(c => char.ToLower(c)) 
                .GroupBy(c => c) 
                //.Select(g => new { Character = g.Key, Count = g.Count() }) 
                .ToList();
            var mostOccurring = characterGroups.OrderByDescending(g => g.Count()).FirstOrDefault();
            var leastOccurring = characterGroups.OrderBy(g => g.Count()).FirstOrDefault();

            if (mostOccurring != null)
            {
                Console.WriteLine($"Most occurring character: '{mostOccurring.Key}' (occurs {mostOccurring.Count()} times)");
            }

            if (leastOccurring != null)
            {
                Console.WriteLine($"Least occurring character: '{leastOccurring.Key}' (occurs {leastOccurring.Count()} time(s))");
            }
        }
    }
}

/*
namespace MaxtLeastOccurenceOfChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char mostOccurring = ' ';
            char leastOccurring = ' ';
            int maxCount = 0;
            int minCount = int.MaxValue;
            string input = "Hello, World! Welcome to the world of Python programming.";
            Dictionary<char, int> charCountDict = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char character = char.ToLower(c);
                    if (charCountDict.ContainsKey(character))
                    {
                        charCountDict[character]++;
                    }
                    else
                    {
                        charCountDict[character] = 1;
                    }
                }
            }
            foreach (var item in charCountDict)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    mostOccurring = item.Key;
                }

                if (item.Value < minCount)
                {
                    minCount = item.Value;
                    leastOccurring = item.Key;
                }
            }

            Console.WriteLine($"Most occurring character: '{mostOccurring}' (occurs {maxCount} times)");
            Console.WriteLine($"Least occurring character: '{leastOccurring}' (occurs {minCount} time(s))");
        }
    }
}
*/
