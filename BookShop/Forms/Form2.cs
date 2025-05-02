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

        private void Form2_Load(object sender, EventArgs e)
        {
            dgv_Books.DataSource = bookBusiness.GetAllBooks();
            cbx_Genre.DataSource = genreBusiness.GetAllGenres().Select(g=>g.Name).ToList();
            cbx_Author.DataSource = authorBusiness.GetAllAuthors().Select(g => g.FirstName + " " + g.LastName).ToList();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string title = tbx_Title.Text;
            decimal price = decimal.Parse(tbx_Price.Text);
            Genre genre = genreBusiness.GetGenreByName(title);
            string[] fullname = cbx_Author.SelectedItem.ToString().Split();
            Author author = authorBusiness.GetGenreByName(fullname[0], fullname[1]);
            Book book = new Book();
            book.Title = title;
            book.Price = price;
            book.Genre = genre;
            book.BookAuthors = new List<BookAuthor>();
            bookBusiness.AddBook(book);
            book = bookBusiness.GetBookByName(title);
            BookAuthor bookAuthor = new BookAuthor();
            bookAuthor.AuthorID = author.AuthorID;
            bookAuthor.Author = author;
            bookAuthor.BookID = book.BookID;
            bookAuthor.Book = book;
            bookAuthorBusiness.AddBookAuthor(bookAuthor);
        }
    }
}
