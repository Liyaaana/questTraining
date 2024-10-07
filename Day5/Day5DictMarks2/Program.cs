using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5DictMarks2
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

                if (studentMarks.ContainsKey(registrationNumber))
                {
                    Console.WriteLine($"Registration number {registrationNumber} already exists. Overwrite? (y/n): ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        // Overwrite the existing marks
                        studentMarks[registrationNumber] = new List<int>();
                    }
                    else
                    {
                        // Skip to the next student
                        continue;
                    }
                }

                List<int> marks = new List<int>();
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"Enter mark {j} for student {i}: ");
                    int mark = int.Parse(Console.ReadLine());
                    marks.Add(mark);
                }
                studentMarks.Add(registrationNumber, marks);
            }

            // Display the student marks
            Console.WriteLine("Entered marks:");
            foreach (var student in studentMarks)
            {
                Console.WriteLine($"Student {student.Key}:");
                foreach (int mark in student.Value)
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
