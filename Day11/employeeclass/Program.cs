using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentMark
{
    class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;

        public void TotalMarks()
        {
            int total = Mark1 + Mark2;
            Console.WriteLine($"Total Marks = {total}");
        }

        public void AvgMarks()
        {
            decimal avg = (Mark1 + Mark2) / 2;
            Console.WriteLine($"Avg Marks = {avg}");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Student student1 = new Student();
            student1.Name = "John";
            student1.Mark1 = 95;

            Student student2 = new Student();
            student2.Name = "Jane";
            student2.Mark2 = 93;

            student1.TotalMarks();
            student2.TotalMarks();
                
            student1.AvgMarks();
            student2.AvgMarks();

        }
    }
}
