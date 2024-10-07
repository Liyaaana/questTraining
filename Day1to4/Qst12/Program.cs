using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();

            }
            */

            int rows = 6;
            int count = 1;
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("{0, 3}", count++);
                }
                Console.WriteLine();
            }
        }
    }
}
