//16: Create a base class Employee with a virtual method CalculateBonus(). In the derived class Manager, override CalculateBonus() to provide a custom calculation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst16
{
    class Employee
    {
        public double Salary { get; set; }
        public virtual void CalculateBonus()
        {
            Console.WriteLine($"Bonus is : {Salary * 0.1}");
        }
    }
    class Manager : Employee
    {
        public override void CalculateBonus()
        {
            Console.WriteLine($"Bonus is : {Salary * 0.2}");
        }

    }

    internal class VirtualTwo
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            manager.Salary = 80_000;
            manager.CalculateBonus();

        }
    }
}

