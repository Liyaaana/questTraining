using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    class SchoolStudent : Student
    {
        public string SchoolName { get; set; }

        // Using the override keyword to provide a custom implementation for the SchoolStudent class.
        public override string ToString() => $"Name: {Name}, Email: {Email}, School: {SchoolName}";
    }

    class CollegeStudent : SchoolStudent
    {
        public string CollegeName { get; set; }
        public override string ToString() => $"Name: {Name}, Email: {Email}, School: {SchoolName}, College: {CollegeName}";

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var cs = new CollegeStudent
            {
                Name = "ABC",
                Email = "ABC@gmail.com",
                SchoolName = "A School",
                CollegeName = "B School"
            };
            Console.WriteLine(cs);
        }
    }
}
