using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note_Taking_Console_Application.Data;
using Note_Taking_Console_Application.Models;

namespace Note_Taking_Console_Application.Services
{
    internal class NoteService
    {
        private readonly NoteRepository noteRepository = new NoteRepository();

        public void CreateNote()
        {
            Console.Write("Enter title: ");
            var title = Console.ReadLine();
            Console.Write("Enter content: ");
            var content = Console.ReadLine();

            var note = new Note
            {
                Title = title,
                Content = content,
                CreatedAt = DateTime.Now
            };

            noteRepository.Create(note);
            Console.WriteLine("Note created successfully.");
        }

        public void DisplayAllNotes()
        {
            var notes = noteRepository.GetAll();
            foreach (var note in notes)
            {
                Console.WriteLine($"ID: {note.Id}, Title: {note.Title}, CreatedAt: {note.CreatedAt}, Content: {note.Content.Substring(0, Math.Min(note.Content.Length, 20))}...");
            }
        }

        public void UpdateNote()
        {
            Console.Write("Enter ID of the note to update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var notes = noteRepository.GetAll();
                var note = notes.Find(n => n.Id == id);
                if (note == null)
                {
                    Console.WriteLine("Note not found.");
                    return;
                }

                Console.WriteLine($"Current title: {note.Title}");
                Console.Write("Enter new title : ");
                var newTitle = Console.ReadLine();
                note.Title = string.IsNullOrWhiteSpace(newTitle) ? note.Title : newTitle;

                Console.WriteLine($"Current content: {note.Content}");
                Console.Write("Enter new content : ");
                var newContent = Console.ReadLine();
                note.Content = string.IsNullOrWhiteSpace(newContent) ? note.Content : newContent;
                note.UpdatedAt = DateTime.Now;

                noteRepository.Update(note);
                Console.WriteLine("Note updated successfully.");
            }
        }

        public void DeleteNote()
        {
            Console.Write("Enter ID of the note to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.Write("Are you sure you want to delete this note? (y/n): ");
                var confirmation = Console.ReadLine();
                if (confirmation?.ToLower() == "y")
                {
                    noteRepository.Delete(id);
                    Console.WriteLine("Note deleted successfully.");
                }
            }
        }
    }
}

