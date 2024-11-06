using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first string: ");
            string firstString = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string secondString = Console.ReadLine();

            bool areAnagrams = AreAnagrams(firstString, secondString);

            if (areAnagrams)
            {
                Console.WriteLine("The two strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The two strings are not anagrams.");
            }
            /*
            if (AreAnagrams(firstString,secondString)==true)
            {
                Console.WriteLine("The two strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The two strings are not anagrams.");
            }
            */
        }

        static bool AreAnagrams(string str1, string str2)
        {
            string cleanStr1 = str1.Replace(" ", "").ToLower();
            string cleanStr2 = str2.Replace(" ", "").ToLower();

            if (cleanStr1.Length != cleanStr2.Length)
            {
                return false; 
            }

            char[] charArray1 = cleanStr1.ToCharArray();
            char[] charArray2 = cleanStr2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            return new string(charArray1) == new string(charArray2);
        }
    }
}
