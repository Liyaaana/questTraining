using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterface
{
    internal interface IStudent
    {
        string Name { get; set; }
        void Display();
    }

    class SchoolStudent : IStudent
    {
        public string Name { get; set; }

        public string SchoolName { get; set; }
        public void Display()
        {
            Console.WriteLine($"Student Name: {Name} , College Name: {SchoolName}");
        }
    }

    class CollegeStudent : IStudent
    {
        public string Name { get; set; }

        public string CollegeName { get; set; }
        public void Display()
        {
            Console.WriteLine($"Student Name: {Name} , College Name: {CollegeName}");
        }
    }
}
