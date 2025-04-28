using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using static NUnit.Framework.Internal.OSPlatform;

namespace Data
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }   
        public DbSet<BookAuthor> AuthorBooks { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public BookStoreContext() : base("name = BookStoreContext")
        {
        }
        public BookStoreContext(System.Data.Common.DbConnection connectionString) : base(connectionString, true)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasKey(x => new {x.AuthorID, x.BookID});
            base.OnModelCreating(modelBuilder);
        }
    }
}
