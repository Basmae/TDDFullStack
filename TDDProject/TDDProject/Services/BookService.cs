using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDDProject.Data;
using TDDProject.Models;

namespace TDDProject.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _context;
        public BookService(BookContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _context.Book.ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            var book = await _context.Book.FindAsync(id);
            return book;
        }

        public async Task<Book> UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
            return book;
        }

        public async Task<Book> AddBook(Book book)
        {
            _context.Book.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return null;
            }

            _context.Book.Remove(book);
            await _context.SaveChangesAsync();

            return book;
        }
    }
}
