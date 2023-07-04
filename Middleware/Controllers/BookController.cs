using Microsoft.AspNetCore.Mvc;
using Middleware.Models;
using Middleware.Repository;
using System.Collections.Generic;

namespace Middleware.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        public ViewResult GetALlBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName) {

            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
