using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsArray;

namespace StudentsArray
{
    class Student
    {
        public string Name;
        public int Marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            var s1 = new Student
            {
                Name = "student 1",
                Marks = 20
            };
            var s2 = new Student
            {
                Name = "student 2",
                Marks = 30
            };
            var s3 = new Student
            {
                Name = "student 3",
                Marks = 50
            };
            Student[] students = new Student[] {s1, s2, s3};
            foreach (var item in students)
            {
                sum = sum + item.Marks;
            }
            Console.WriteLine($"the total marks is {sum}");
        }
    }
}
