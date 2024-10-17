using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagemnt;

namespace StudentManagemnt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentManager = new StudentManager();

            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Search Student");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("Enter your option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        var student = GetStudentData();
                        studentManager.Add(student);
                        break;

                    case "2":
                        Console.Write("Enter the registration number to search: ");
                        var regNo = Console.ReadLine();
                        studentManager.Search(regNo);
                        break;

                    case "3":

                        var studentToUpdate = GetStudentData();
                        studentManager.Update(
                            studentToUpdate.RegNo,
                            studentToUpdate.Name,
                            studentToUpdate.Class,
                            studentToUpdate.Subject1Marks,
                            studentToUpdate.Subject2Marks,
                            studentToUpdate.Subject3Marks
                        );
                        break;

                    case "4":
                        Console.Write("Enter the registration number to delete: ");
                        var regNoToDelete = Console.ReadLine();
                        studentManager.Delete(regNoToDelete);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        // Method to get student data from user input
        private static Student GetStudentData()
        {
            Student student = new Student();

            Console.Write("Enter student name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter registration number: ");
            student.RegNo = Console.ReadLine();

            Console.Write("Enter class: ");
            student.Class = Console.ReadLine();

            Console.Write("Enter marks for Subject 1: ");
            student.Subject1Marks = int.Parse(Console.ReadLine());

            Console.Write("Enter marks for Subject 2: ");
            student.Subject2Marks = int.Parse(Console.ReadLine());

            Console.Write("Enter marks for Subject 3: ");
            student.Subject3Marks = int.Parse(Console.ReadLine());

            return student;
        }
    }
}