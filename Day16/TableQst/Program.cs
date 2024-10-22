using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableQst
{
    internal class Program
    {
        
        const string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\liyan\OneDrive\Documents\QuestDB.mdf;Integrated Security=True;";

        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("Book 1", "Author A", 500),
                new Book("Book 2", "Author B", 600),
                new Book("Book 3", "Author C", 700),
                new Book("Book 4", "Author D", 800),
                new Book("Book 5", "Author E", 900)
            };

            InsertBooksIntoDatabase(books);
        }

        static void InsertBooksIntoDatabase(List<Book> books)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                foreach (var book in books)
                {
                    var insertQuery = @"INSERT INTO BOOKS (name, author, price) VALUES (@name, @author, @price)";
                    using (var command = new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@name", book.Name);
                        command.Parameters.AddWithValue("@author", book.Author);
                        command.Parameters.AddWithValue("@price", book.Price);

                        command.ExecuteNonQuery();
                    }
                }

                conn.Close();
                Console.WriteLine("Books inserted successfully.");
            }
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public Book(string name, string author, int price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
    }
}
