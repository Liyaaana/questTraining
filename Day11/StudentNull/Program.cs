using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student
            { 
                Name = "Student1", 
                Mark1 = 10,
                Mark2 = 20
            };
            var s2 = new Student
            { 
                Name = "Student2", 
                Mark1 = 10, 
                Mark2= 20
            };
            var s3= new Student
            {
                Name = "Student3",
                Mark1 = 10,
                Mark2 = 20
            };

            Student[] students = new Student[5];
            students[0] = s1;
            students[1] = s2;
            students[2] = s3;

            foreach (var student in students)
            {
                if (student != null)
                    Console.WriteLine(student.Name);
            }
        }
    }
}
