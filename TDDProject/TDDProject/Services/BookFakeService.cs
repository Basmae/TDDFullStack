using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDDProject.Models;

namespace TDDProject.Services
{
    public class BookFakeService : IBookService
    {
        private readonly List<Book> _books;
        public BookFakeService()
        {
            _books = new List<Book>()
            {
                new Book
                {
                    Id= 1,
                    Title= "title1",
                    Author = "author1"
                },
                new Book
                {
                    Id= 2,
                    Title= "title2",
                    Author = "author2"
                },
                new Book
                {
                    Id= 3,
                    Title= "title3",
                    Author = "author3"
                },
            };
        
        }
        public async Task<Book> AddBook(Book book)
        {
            var newIndex = _books.Count + 1;
            book.Id = newIndex;
            _books.Add(book);
            return book;
        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = _books.Find(b => b.Id == id);
            _books.Remove(book);
            return book;
        }

        public async Task<Book> GetBook(int id)
        {
            var book = _books.Find(b => b.Id == id);
            return book;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            var books = _books.AsEnumerable();
            return books;
        }

        public async Task<Book> UpdateBook(Book book)
        {
            var existingbook = _books.Find(b => b.Id == book.Id);
            existingbook = book;
            return existingbook;
        }
    }
}
