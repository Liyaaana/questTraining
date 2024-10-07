using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5DictMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentMarks = new Dictionary<int, List<int>>();

            for (int i = 1; i <= 2; i++)
            {
                Console.Write($"Enter registration number for student {i}: ");
                int registrationNumber = int.Parse(Console.ReadLine());

                var marks = new List<int>();
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"Enter mark {j} for student {i}: ");
                    int mark = int.Parse(Console.ReadLine());
                    marks.Add(mark);
                }
                // Adds the marks list to the studentMarks dictionary, using the student's registration number registrationNumber as the key.
                studentMarks.Add(registrationNumber, marks);
            }

            // Display the student marks
            Console.WriteLine("Entered marks:");
            foreach (var student in studentMarks)
            {
                Console.WriteLine($"Student {student.Key}:");
                // Iterates over each mark in the value (list of marks) associated with the current student.
                foreach (int mark in student.Value)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
