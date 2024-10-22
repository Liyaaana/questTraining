using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Repositories;
// Books, Members
// List all books,
// Search by name, id,
// List all members,
// search member by name, email

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var memberRepository = new MemberRepository();

            var result = memberRepository.GetMemberById(10);
            if (result.Success)
            {
                Console.WriteLine(result.Data.Name);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            var bookRepository = new BookRepository();

            var res = bookRepository.GetBookById(2);
            if (res.Success)
            {
                Console.WriteLine(res.Data.Title);
            }
            else
            {
                Console.WriteLine(res.Message);
            }
        }
    }
}
