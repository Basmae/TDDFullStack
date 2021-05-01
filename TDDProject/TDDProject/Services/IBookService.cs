using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDDProject.Models;

namespace TDDProject.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBook(int id);
        Task<Book> UpdateBook(Book book);
        Task<Book> AddBook(Book book);
        Task<Book> DeleteBook(int id);
    }
}
