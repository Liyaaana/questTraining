using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplicatn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\liyan\OneDrive\Documents\QuestDB.mdf;Integrated Security=True";

            /*var createTableQuery = @"CREATE TABLE Books
                                    (
                                        id INT PRIMARY KEY IDENTITY,
                                        name VARCHAR(50),
                                        author VARCHAR(50),
                                        price INT DEFAULT 0
                                    )";
            */
            var createTableQuery = @"CREATE TABLE Contacts
                                    (
                                        id INT PRIMARY KEY IDENTITY,
                                        name VARCHAR(50),
                                        phone VARCHAR(50)
                                        email VARCHAR(50)
                                    )";
            var conn = new SqlConnection(connStr);
            conn.Open();

            var command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();
            conn.Close();          
        }
    }
}
