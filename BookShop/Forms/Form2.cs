using System;
using Data;
using Data.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Buisness_Logick;
using Business.Buisness_Logic;
using Data1.viewModels;

namespace BookShop.Forms
{
    public partial class Form2 : Form
    {
        BookStoreContext context = new BookStoreContext();
        BookBusiness bookBusiness => new BookBusiness(context);
        GenreBusiness genreBusiness => new GenreBusiness(context);
        AuthorBusiness authorBusiness => new AuthorBusiness(context);
        BookAuthorBusiness bookAuthorBusiness => new BookAuthorBusiness(context);
        public Form2()
        {
            InitializeComponent();
        }
        List<ViewBook> viewBooks = new List<ViewBook>();

        private void Form2_Load(object sender, EventArgs e)
        {
            //var books = bookBusiness.GetAllBooks();
            //foreach (var item in books)
            //{
            //    ViewBook viewBook = new ViewBook()
            //    {
            //        Title = item.Title,
            //        Price = item.Price,
            //        Genre = item.Se.Name,
            //        Author = item.BookAuthors.FirstOrDefault().Author.FirstName + " " + item.BookAuthors.FirstOrDefault().Author.LastName
            //    };
            //    viewBooks.Add(viewBook);
            //}
            dgv_Books.DataSource = null;
            dgv_Books.DataSource = bookBusiness.GetAllBooks();
            cbx_Genre.DataSource = genreBusiness.GetAllGenres().Select(g => g.Name).ToList();
            cbx_Author.DataSource = authorBusiness.GetAllAuthors().Select(g => g.FirstName + " " + g.LastName).ToList();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string title = tbx_Title.Text;
            decimal price = decimal.Parse(tbx_Price.Text);
            Genre genre = genreBusiness.GetGenreByName(cbx_Genre.SelectedItem.ToString());
            Author author = authorBusiness.GetAuthorByName(cbx_Author.SelectedItem.ToString());
            Book book = new Book()
            {
                Title = title,
                Price = price,
                GenreID = genre.GenreID,
                Genre = genre,
                BookAuthors = new List<BookAuthor>()
            };
            bookBusiness.AddBook(book);
            book = bookBusiness.GetBookByName(title);
            BookAuthor bookAuthor = new BookAuthor()
            {
                BookID = book.BookID,
                AuthorID = author.AuthorID,
                Book = book,
                Author = author
            };
            bookAuthorBusiness.AddBookAuthor(bookAuthor);
            //string authorName = book.BookAuthors.First(ba => ba.BookID == book.BookID).Author.FirstName + " " + book.BookAuthors.First(ba => ba.BookID == book.BookID).Author.LastName;
            //viewBooks.Add(new ViewBook()
            //{
            //    Title = book.Title,
            //    Price = book.Price,
            //    Genre = book.Genre.Name,
            //    Author = authorName
            //});
            dgv_Books.DataSource = null;
            dgv_Books.DataSource = bookBusiness.GetAllBooks();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
