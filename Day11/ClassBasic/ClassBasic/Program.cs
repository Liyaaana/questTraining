using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasic
{
    class Student
    {
        public string Name;

        public void DisplayName()
        {
            Console.WriteLine(Name.ToUpper());
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student s = new Student();
            s.Name = "John";
            s.DisplayName();

            Student s1 = new Student();
            s1.Name = "Jane";
            s1.DisplayName();

        }
    }
}
