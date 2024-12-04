using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Application-Level Question: Note-Taking Console Application

Objective:
Develop a console application in C# that allows users to create, read, update, and delete notes. Each note should be stored in a MSSQL database. The application should follow best practices in software design, including separation of concerns, and should be user-friendly.

Requirements:

Database Design:

Create a database named NoteTakingApp.
Create a table named Notes with the following columns:

Title 
Content
CreatedAt
UpdatedAt
Application Features:

User Interface:

Display a menu with the following options:

Create a new note
View all notes
Update an existing note
Delete a note
Exit the application
Create a Note:

Prompt the user for the note title and content.
Validate input (e.g., title and content should not be empty).
Save the note to the database.
View All Notes:

Retrieve and display all notes from the database, showing the title, creation date, and a snippet of the content.
Update a Note:

Prompt the user to select a note to update (by ID).
Display the current title and content.
Allow the user to update the title and/or content.
Save the changes back to the database.
Delete a Note:

Prompt the user to select a note to delete (by ID).
Confirm the deletion before removing the note from the database.
Exit:

Gracefully exit the application.
Data Access Layer:

Create a Note model class that represents the Notes table.
Implement a repository pattern to encapsulate data access logic.
Error Handling:

Implement error handling for database operations (e.g., connection issues, validation errors).
Provide user-friendly error messages.
Logging:

Implement basic logging to track application events (e.g., note creation, updates, deletions).
Use a simple logging mechanism (e.g., console output or a text file).

Bonus Features (Optional):

Implement search functionality to find notes by title or content.
Allow users to categorize notes (e.g., personal, work, etc.) and filter notes by category.
*/

namespace Note_Taking_Console_Application.Models
{
    internal class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Note(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}
