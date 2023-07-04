using Microsoft.AspNetCore.Mvc;

namespace Middleware.Controllers
{
    public class BookController : Controller
    {
        public string ShowBook()
        {
            return "All Books";
        }
        public string GetBook(int id)
        {
            return $"book with id = {id}";
        }
        public string SearchBooks(string bookName, string authorName) {

            return $"book with name = {bookName} & authorname = {authorName}";
        }
    }
}
