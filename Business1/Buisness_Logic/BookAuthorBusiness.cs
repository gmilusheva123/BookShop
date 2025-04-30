using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Buisness_Logick
{
    public class BookAuthorBusiness
    {
        BookStoreContext bookStoreContext = new BookStoreContext();
        public BookAuthorBusiness(BookStoreContext context)
        {
            bookStoreContext = context;
        }
        public List<BookAuthor> GetAllBookAuthors()
        {
            return bookStoreContext.BookAuthors.ToList();
        }
        public BookAuthor GetBookAuthorByID(int id)
        {
            return bookStoreContext.BookAuthors.Find(id);
        }
        public string AddBookAuthor(BookAuthor bookAuthor)
        {
            bookStoreContext.BookAuthors.Add(bookAuthor);
            bookStoreContext.SaveChanges();
            return "You added BookAuthor.";
        }
        public string RemoveGenre(int id)
        {
            bookStoreContext.BookAuthors.Remove(GetBookAuthorByID(id));
            bookStoreContext.SaveChanges();
            return "BookAuthor is removed successfully.";
        }
        public string UpdateBookAuthor(BookAuthor bookAuthor)
        {
            BookAuthor bookAuthor2 = bookStoreContext.BookAuthors.Find(bookAuthor.BookID);
            bookStoreContext.Entry(bookAuthor2).CurrentValues.SetValues(bookAuthor);
            bookStoreContext.SaveChanges();
            return $"BookAuthor has been updated successfully.";
        }
    }
}
