using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Note_Taking_Console_Application.Models;

namespace Note_Taking_Console_Application.Data
{
    internal class NoteRepository
    {
        public void Create(Note note)
        {
            using (var connection = Database.GetConnection())
            {
                var query = "INSERT INTO Notes (Title, Content, CreatedAt) VALUES (@Title, @Content, @CreatedAt)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", note.Title);
                command.Parameters.AddWithValue("@Content", note.Content);
                command.Parameters.AddWithValue("@CreatedAt", note.CreatedAt);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Note> GetAll()
        {
            var notes = new List<Note>();
            using (var connection = Database.GetConnection())
            {
                var query = "SELECT * FROM Notes";
                var command = new SqlCommand(query, connection);
                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    notes.Add(new Note
                    {
                        Id = (int)reader["Id"],
                        Title = (string)reader["Title"],
                        Content = (string)reader["Content"],
                        CreatedAt = (DateTime)reader["CreatedAt"],
                        UpdatedAt = reader["UpdatedAt"] as DateTime?
                    });
                }
            }
            return notes;
        }

        public void Update(Note note)
        {
            using (var connection = Database.GetConnection())
            {
                var query = "UPDATE Notes SET Title = @Title, Content = @Content, UpdatedAt = @UpdatedAt WHERE Id = @Id";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", note.Title);
                command.Parameters.AddWithValue("@Content", note.Content);
                command.Parameters.AddWithValue("@UpdatedAt", note.UpdatedAt);
                command.Parameters.AddWithValue("@Id", note.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = Database.GetConnection())
            {
                var query = "DELETE FROM Notes WHERE Id = @Id";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
