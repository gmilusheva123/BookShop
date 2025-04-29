using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Buisness_Logick
{
    public class AuthorBusiness
    {
        BookStoreContext bookStoreContext = new BookStoreContext();
        public Author GetAuthorByID(int id)
        {
            return bookStoreContext.Authors.Find(id);
        }
        public string AddAuthor(Author author)
        {
            bookStoreContext.Authors.Add(author);
            bookStoreContext.SaveChanges();
            return "You added an author.";
        }
        public string RemoveAuthor(int id)
        {
            bookStoreContext.Authors.Remove(GetAuthorByID(id));
            bookStoreContext.SaveChanges();
            return "Author is removed successfully.";
        }
        public string UpdateAuthor(Author author)
        {
            Author author1 = GetAuthorByID(author.AuthorID);
            bookStoreContext.Entry(author1).CurrentValues.SetValues(author);
            bookStoreContext.SaveChanges();
            return $"Author has been updated successfully.";
        }
    }
}
