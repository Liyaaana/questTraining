using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagement.Entities;

namespace BookManagement.Services
{
    internal interface IStorageService
    {
        void Save(Book book);
        Book Search(String Title);
        Book GetById(int Id);
        void Delete(int Id);
    }
}
