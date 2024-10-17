using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace properties2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student();
            s1.Name = "Student1";

            s1.Marks = new List<Mark>();
            s1.Marks.Add(new Mark{ Subject = "Physics", MarkObtained = 45 });
            s1.Marks.Add(new Mark{ Subject = "Maths", MarkObtained = 47 });
        }
    }
}
