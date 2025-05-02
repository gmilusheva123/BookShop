using Business.Buisness_Logic;
using Data;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.Forms
{
    //искам да попитам, правя един курсов трислоен проект на тема BookShop на
    //c# WindowsFormApp и ми трябва помощ с дизайна на формите,
    //като имам таблици за Жанр, Автор, Книга и Кинга и Автор
    public partial class Form4 : Form
    {
        BookStoreContext context = new BookStoreContext();
        GenreBusiness genreBusiness => new GenreBusiness(context);
        public Form4()
        {
            InitializeComponent();
        }
        private void tbx_Genre_Load(object sender, EventArgs e)
        {
            dgv_Genres.DataSource = genreBusiness.GetAllGenres();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string genre = tbx_Genre.Text;
            string messege = genreBusiness.AddGenre(new Genre { Name = genre,Books = new List<Book>()});
            MessageBox.Show(messege);
            dgv_Genres.DataSource = genreBusiness.GetAllGenres();
        }
    }
}
