using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using TDDProject.Controllers;
using TDDProject.Data;
using TDDProject.Models;
using TDDProject.Services;

namespace BooksUnitTest
{
    public class Tests
    {
        private BooksController _booksController;
        private IBookService _bookService;
        public Tests()
        {
            _bookService = new BookFakeService();
            _booksController = new BooksController(_bookService);
        }

        [Test]
        public async Task AddBookTest()
        {
            var book = new Book()
            {
                Author = "authorTest",
                Title = "titleTest"
            };
            var actionResult = await _booksController.PostBook(book);

            var okResult = (OkObjectResult) actionResult.Result;
            var result = okResult.Value as Book;
            var expected = new Book()
            {
                Id = 4,
                Author = "authorTest",
                Title = "titleTest"
            };
            Assert.AreEqual(expected.Id, result.Id);
            Assert.AreEqual(expected.Author, result.Author);
            Assert.AreEqual(expected.Title, result.Title);
        }

        [Test]
        public async Task GetFirstBookTest()
        {
            var actionResult = await _booksController.GetBook(1);

            var result = actionResult.Value;
            var expected = new Book()
            {
                Id = 1,
                Author = "author1",
                Title = "title1"
            };
            Assert.AreEqual(expected.Id, result.Id);
            Assert.AreEqual(expected.Author, result.Author);
            Assert.AreEqual(expected.Title, result.Title);
        }

        [Test]
        public async Task GetSecondBookTest()
        {
            var actionResult = await _booksController.GetBook(2);

            var result = actionResult.Value;
            var expected = new Book()
            {
                Id = 2,
                Author = "author2",
                Title = "title2"
            };
            Assert.AreEqual(expected.Id, result.Id);
            Assert.AreEqual(expected.Author, result.Author);
            Assert.AreEqual(expected.Title, result.Title);
        }

        [Test]
        public async Task DeleteBookTest()
        {
            var actionResult = await _booksController.DeleteBook(3);
            var result = actionResult.Value;
            var expected = new Book()
            {
                Id = 3,
                Author = "author3",
                Title = "title3"
            };
            Assert.AreEqual(expected.Id, result.Id);
            Assert.AreEqual(expected.Author, result.Author);
            Assert.AreEqual(expected.Title, result.Title);
        }

        [Test]
        public async Task UpdateBookTest()
        {
            var book = new Book()
            {
                Id = 1,
                Author = "author1updated",
                Title = "title1"
            };
            var actionResult = await _booksController.PutBook(1, book);

            var okResult = (OkObjectResult)actionResult.Result;
            var result = okResult.Value as Book;
            var expected = new Book()
            {
                Id = 1,
                Author = "author1updated",
                Title = "title1"
            };
            Assert.AreEqual(expected.Id, result.Id);
            Assert.AreEqual(expected.Author, result.Author);
            Assert.AreEqual(expected.Title, result.Title);
        }
    }
}