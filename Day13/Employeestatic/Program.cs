using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeestatic
{
    class Employee
    {
        public string Name { get; set; }
        public static string CompanyName { get; set; }
        override public string ToString() => $"Name: {Name}, Company: {CompanyName}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee.CompanyName = "Old Name"; // var e1 = new Employee { CompanyName = "Old Name" }; is not possible since static cannot be accessed in the name of object, instead accessed by its class. 
            var e1 = new Employee { Name = "E1" };
            var e2 = new Employee { Name = "E2" };

            Console.WriteLine(e1); 
            Console.WriteLine(e2);

            Employee.CompanyName = "New Name";
            Console.WriteLine(e1);
            Console.WriteLine(e2);
        }
    }
}
