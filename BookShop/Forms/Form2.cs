using System;
using Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Buisness_Logick;

namespace BookShop.Forms
{
    public partial class Form2 : Form
    {
        BookStoreContext context = new BookStoreContext();
        BookBusiness bookBusiness => new BookBusiness(context);
        public Form2()
        {
            InitializeComponent();
            //dgv_Books.DataSource = 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dgv_Books.DataSource = bookBusiness.GetAllOrders();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
