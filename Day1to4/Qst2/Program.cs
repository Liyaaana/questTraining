﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst2
{
    internal class Program
    {
        static int SingleLineAddWithReturn(int a, int b) => a + b;

        static void Greet() => Console.WriteLine("Hello!");

        static void GreetByName(string firstName, string lastName = "")
        {
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }

        static int Add(int a, int b) => a + b;

        static void Main(string[] args)
        {
            Greet();
            GreetByName("John");
            GreetByName("John", "Doe");

            int result = Add(1, 2);
            Console.WriteLine(result);

            int sum = SingleLineAddWithReturn(1, 2);
            Console.WriteLine(sum);

            string[] names = { "John Doe", "Jane Doe" };
            string toSearch = "doe";

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i].ToLower();
                if (name.Contains(toSearch.ToLower()))
                {
                    Console.WriteLine("Name found!");
                }
            }
        }
    }
}
