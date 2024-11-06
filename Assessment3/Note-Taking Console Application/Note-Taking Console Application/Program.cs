using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note_Taking_Console_Application.Data;
using Note_Taking_Console_Application.Models;
using Note_Taking_Console_Application.Services;

namespace Note_Taking_Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var noteService = new NoteService();
            bool input = true;

            while (input)
            {
                Console.WriteLine("\n1. Create a new note");
                Console.WriteLine("2. View all notes");
                Console.WriteLine("3. Update an existing note");
                Console.WriteLine("4. Delete a note");
                Console.WriteLine("5. Exit");

                Console.Write("Select an option: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        noteService.CreateNote();
                        break;
                    case "2":
                        noteService.DisplayAllNotes();
                        break;
                    case "3":
                        noteService.UpdateNote();
                        break;
                    case "4":
                        noteService.DeleteNote();
                        break;
                    case "5":
                        input = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option! Please try again.");
                        break;
                }
            }
        }
    }
}