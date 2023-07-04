using Middleware.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Middleware.Repository
{
    public class BookRepository
    {

            public List<BookModel> GetAllBooks(){
                return DataSource();
            }

            public BookModel  GetBookById(int id)
            {
                return DataSource().Where(x => x.Id == id).FirstOrDefault();       
            }

            public List<BookModel> SearchBook(string title, string authorName)
            {
                return DataSource().Where(x => x.Title == title && x.Author == authorName).ToList();
            }

            private List<BookModel>DataSource()
            {
                return new List<BookModel>() { 
                    new BookModel(){Id = 1, Title="MVC", Author="Test"},
                    new BookModel(){Id = 2, Title="OOP", Author="Check"},
                    new BookModel(){Id = 3, Title="PHP", Author="Oy"},
                    new BookModel(){Id = 4, Title="ASP", Author="Mark"},
                    new BookModel(){Id = 5, Title="NET", Author="Oliver"},
                };
            }

        }
    }
