using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your date of birth (DD/MM/YYYY): ");
            var dob = Console.ReadLine();
            int age = today.Year - dob.Year;
            Console.WriteLine("Age is: " + age);
        }
    }
}
