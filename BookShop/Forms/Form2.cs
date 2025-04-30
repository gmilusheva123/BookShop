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
        public Form2()
        {
            InitializeComponent();
            //dgv_Books.DataSource = 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgv_Books.DataSource = bookBusiness.GetAllBooks();
            lstbx_Genre.DataSource = genreBusiness.GetAllGenres().Select(g=>g.Name).ToList();
            //genreBusiness.AddGenre()
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }
    }
}
