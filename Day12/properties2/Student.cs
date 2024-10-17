using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties2
{
    partial class Student
    {
        public string Name { get; set; }
        public List<Mark> Marks { get; set; }
    }

    class Mark
    {
        public string Subject { get; set; }
        public int MarkObtained { get; set; }
    }
}
