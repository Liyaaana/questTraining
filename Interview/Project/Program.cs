using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        

        public static void Display()
        {
            List<int> arr2 = new List<int>();          
            for (int i = 1; i <= 10; i++)
            {   
                if (i == 7)
                {
                    continue;
                
                }
                arr2.Add(i);
            }
            Console.WriteLine(string.Join(", ", arr2));

        }
        public static void Main(string[] args)
        {
            Display();
        }
    }
}

