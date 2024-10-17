using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagemnt
{
    internal class Student
    {
        public string Name;
        public string Class;
        public string RegNo;
        public int Subject1Marks; // Marks for subject 1
        public int Subject2Marks; // Marks for subject 2
        public int Subject3Marks; // Marks for subject 3

        public override string ToString()
        {
            return $"Name: {Name}, Class: {Class}, Reg No: {RegNo}, " +
                   $"Subject 1 Marks: {Subject1Marks}, " +
                   $"Subject 2 Marks: {Subject2Marks}, " +
                   $"Subject 3 Marks: {Subject3Marks}";
        }
    }
}