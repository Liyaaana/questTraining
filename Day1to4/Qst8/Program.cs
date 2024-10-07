using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // One, 2, Three, Four, 2
            // One, Two, Three, Four, Two
            var numbers = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            string input = "One, 2, Three, Four, 2";
            var inputItems = input.Replace(" ", "").Split(',');
            var sb = new StringBuilder();
            foreach (var item in inputItems)
            {
                if (item.Length <= 2)
                {
                    int number = int.Parse(item);
                    string text = numbers[number - 1];
                    sb.Append($"{text}, ");
                }
                else
                {
                    sb.Append($"{item}, ");
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
