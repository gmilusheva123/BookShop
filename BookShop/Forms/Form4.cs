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
        /// <summary>
        /// Adds a genre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string genre = tbx_Genre.Text;
            string messege = genreBusiness.AddGenre(new Genre { Name = genre,Books = new List<Book>()});
            MessageBox.Show(messege);
            dgv_Genres.DataSource = genreBusiness.GetAllGenres();
        }
        /// <summary>
        /// Deletes the selected genre. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Genre removedGenre = dgv_Genres.CurrentRow.DataBoundItem as Genre;
            string message = genreBusiness.RemoveGenre(removedGenre.GenreID);
            MessageBox.Show(message);
            dgv_Genres.DataSource = genreBusiness.GetAllGenres();
        }  

        /// <summary>
        /// Updates the name of the selected genre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {
            Genre updatedGenre = dgv_Genres.CurrentRow.DataBoundItem as Genre;
            string genre = tbx_Genre.Text;
            updatedGenre.Name = genre;
            string messege = genreBusiness.UpdateGenre(updatedGenre);
            MessageBox.Show(messege);
            dgv_Genres.DataSource = genreBusiness.GetAllGenres();
        }

        private void dgv_Genres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
