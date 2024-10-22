using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class ContactRepository
    {
        private string connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\liyan\\OneDrive\\Documents\\QuestDB.mdf;Integrated Security=True";

        public ContactRepository()
        {
            CreateContactsTable();
        }

        private void CreateContactsTable()
        {
            string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Contacts' AND xtype='U')
            CREATE TABLE Contacts (
                ContactID INT PRIMARY KEY IDENTITY(1,1),
                Name VARCHAR(100) NOT NULL,
                Phone VARCHAR(20) NOT NULL,
                Email VARCHAR(100) NULL
            );";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(createTableQuery, connection);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }

        public void AddContact(Contact contact)
        {
            string query = "INSERT INTO Contacts (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", contact.Name);
                command.Parameters.AddWithValue("@Phone", contact.Phone);
                command.Parameters.AddWithValue("@Email", contact.Email ?? (object)DBNull.Value);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }

        public Contact SearchByNameOrPhone(string input)
        {
            string query = "SELECT * FROM Contacts WHERE Name = @Input OR Phone = @Input";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Input", input);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Contact
                        {
                            ContactID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Phone = reader.GetString(2),
                            Email = reader.IsDBNull(3) ? null : reader.GetString(3)
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateContact(Contact contact)
        {
            string query = "UPDATE Contacts SET Name = @Name, Phone = @Phone, Email = @Email WHERE ContactID = @ContactID";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", contact.Name);
                command.Parameters.AddWithValue("@Phone", contact.Phone);
                command.Parameters.AddWithValue("@Email", contact.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContactID", contact.ContactID);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }

        public void DeleteContact(int contactID)
        {
            string query = "DELETE FROM Contacts WHERE ContactID = @ContactID";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContactID", contactID);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ContactRepository repository = new ContactRepository();

            repository.AddContact(new Contact { Name = "John Doe", Phone = "123456789", Email = "john@example.com" });

            var contact = repository.SearchByNameOrPhone("John Doe");
            if (contact != null)
            {
                Console.WriteLine($"Found: {contact.Name}, Phone: {contact.Phone}, Email: {contact.Email}");

                contact.Name = "John Smith";
                repository.UpdateContact(contact);
                Console.WriteLine("Contact updated.");

                repository.DeleteContact(contact.ContactID);
                Console.WriteLine("Contact deleted.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }

            Console.ReadLine();
        }
    }
}    
