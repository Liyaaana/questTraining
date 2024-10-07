using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst1
{
    internal class Program
    {
        static void Greet()
        {
            Console.WriteLine("Hello!");
        }

        static void GreetByName(string firstName)
        {
            Console.WriteLine($"Hello, {firstName}!");
        }
        // Method overloading
        static void GreetByName(string firstName, string lastName)
        {
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Greet();
            GreetByName("John");
            GreetByName("John", "Doe");

            int result = Add(1, 2);
            Console.WriteLine(result);


            string[] names = { "John Doe", "Jane Doe" };
            string toSearch = " doe";

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i].ToLower();

                if (name.Contains(toSearch.ToLower()))
                {
                    Console.WriteLine("Name found: " + name);
                }
            }
        }
    }
}
