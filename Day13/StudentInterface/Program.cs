using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<IStudent>
            {
                new SchoolStudent { Name = "John"},
                new SchoolStudent { Name = "Jamy"},
                new SchoolStudent { Name = "Sam"},
                new SchoolStudent { Name = "Tim"}
            };

            foreach (var student in students)
            {
                student.Display();
            }
        }
    }
}
