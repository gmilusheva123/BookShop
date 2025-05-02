using Business.Buisness_Logick;
using Data;
using Data.Models;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop.Forms
{
    public partial class Form3 : Form
    {
        BookStoreContext context = new BookStoreContext();
        AuthorBusiness authorBusiness => new AuthorBusiness(context);
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgv_Authors.DataSource = authorBusiness.GetAllAuthors();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string firstName = tbx_FirstName.Text;
            string lastName = tbx_LastName.Text;
            string nationality = tbx_Nationality.Text;
            Author author = new Author();
            author.FirstName = firstName;
            author.LastName = lastName;
            author.Nationality = nationality;
            string message = authorBusiness.AddAuthor(author);
            MessageBox.Show(message);
            dgv_Authors.DataSource = authorBusiness.GetAllAuthors();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Author removedAuthor = dgv_Authors.CurrentRow.DataBoundItem as Author;
            string message = authorBusiness.RemoveAuthor(removedAuthor.AuthorID);
            MessageBox.Show(message);
            dgv_Authors.DataSource = authorBusiness.GetAllAuthors();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Author updatedAuthor = dgv_Authors.CurrentRow.DataBoundItem as Author;
            string firstName = tbx_FirstName.Text;
            string lastName = tbx_LastName.Text;
            string nationality = tbx_Nationality.Text;
            updatedAuthor.FirstName = firstName;
            updatedAuthor.LastName = lastName;
            updatedAuthor.Nationality = nationality;
            string message = authorBusiness.UpdateAuthor(updatedAuthor);
            MessageBox.Show(message);
            dgv_Authors.DataSource = authorBusiness.GetAllAuthors();
        }
    }
}
