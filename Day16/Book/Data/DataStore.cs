using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Data
{
    internal static class DataStore
    {
        public static List<Book> Books;
        public static List<Member> Members;

        static DataStore()
        {
            Members = new List<Member>()
            {
                new Member{Id=1, Name="Uncategorized" , Email="123exapmle@gmail.com"}
            };

            Books = new List<Book>()
            {
                new Book{BookId = 1, Title = "Product 1", Author = "Author 1"},
                new Book{BookId = 2, Title = "Product 2", Author = "Author 2"}
            };
        }
    }
}
