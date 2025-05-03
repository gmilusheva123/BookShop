using Business.Buisness_Logic;
using Business.Buisness_Logick;
using Data;
using Data.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BookShop.Forms
{
    public partial class Form6 : Form
    {
        BookStoreContext context = new BookStoreContext();
        BookBusiness bookBusiness => new BookBusiness(context);
        AuthorBusiness authorBusiness => new AuthorBusiness(context);
        GenreBusiness genreBusiness => new GenreBusiness(context);


        public Form6()
        {
            InitializeComponent();
        }

        private void btn_OutputQuery1_Click(object sender, EventArgs e)
        {
            //if (cbx_Query1.SelectedItem is Auth selectedAuthor)
            //{
            //    var books = context.BookAuthors
            //        .Where(ba => ba.AuthorID == selectedAuthor.AuthorID)
            //        .Select(ba => new
            //        {
            //            Заглавие = ba.Book.Title
            //        })
            //        .ToList();

            //    dgv_Query.DataSource = books;
            //}
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //var authors = context.Authors
            //                     .OrderBy(a => a.FirstName)
            //                     .ThenBy(a => a.LastName)
            //                     .ToList();

            //cbx_Query1.DataSource = authors;
            //cbx_Query1.DisplayMember = "FullName";
            //cbx_Query1.ValueMember = "Id";
        }

        private void btn_Query2_Click(object sender, EventArgs e)
        {
            var books = context.Books
                .Where(b => b.Price > 10)
                .Select(b => new
                {
                    Заглавие = b.Title,
                    Цена = b.Price
                })
                .ToList();

            dgv_Query.DataSource = books;
        }

        private void btn_Query3_Click(object sender, EventArgs e)
        {
            if (cbx_GenreQuery3.SelectedItem is Genre selectedGenre)
            {
                    var books = context.Books
                        .Where(b => b.GenreID == selectedGenre.GenreID)
                        .Select(b => new
                        {
                            Заглавие = b.Title,
                            Цена = b.Price,
                            Жанр = b.Genre.Name
                        })
                        .ToList();

                    dgv_Query.DataSource = books;
                }
            }
        }
    }
