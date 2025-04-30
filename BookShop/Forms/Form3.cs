using Business.Buisness_Logick;
using Data;
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
    }
}
