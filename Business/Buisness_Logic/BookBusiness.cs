using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Buisness_Logick
{
    public class BookBusiness
    {
        BookStoreContext bookStoreContext = new BookStoreContext();
        public List<Book> GetAllOrders()
        {
            return bookStoreContext.Books.ToList();
        }

        public Book GetBookByID(int id)
        {
            return bookStoreContext.Books.Find(id);
        }
        public string AddBook(Book book)
        {
            bookStoreContext.Books.Add(book);
            bookStoreContext.SaveChanges();
            return "You added a book.";
        }
        public string RemoveBook(int id)
        {
            bookStoreContext.Books.Remove(GetBookByID(id));
            bookStoreContext.SaveChanges();
            return "Book is removed successfully.";
        }
        public string UpdateBook(Book book)
        {
            Book book1 = GetBookByID(book.BookID);
            bookStoreContext.Entry(book1).CurrentValues.SetValues(book);
            bookStoreContext.SaveChanges();
            return $"Book with {book.Title} update successfully.";
        }
    }
}