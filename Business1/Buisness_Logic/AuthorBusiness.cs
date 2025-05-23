﻿using Data;
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
        public AuthorBusiness(BookStoreContext context)
        {
            bookStoreContext = context;
        }
        public Author GetAuthorByName(string fullName)
        {
            string[] names = fullName.Split(' ');
            string firstName = names[0];
            string secondName = names[1];
            return bookStoreContext.Authors.FirstOrDefault(g => g.FirstName == firstName && g.LastName == secondName);
        }
        public List<Author> GetAllAuthors()
        {
            return bookStoreContext.Authors.ToList();
        }
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
