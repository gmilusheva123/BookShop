using BookShop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            Form2 admin = new Form2();
            admin.Show();
            admin.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void btn_Author_Click(object sender, EventArgs e)
        {
            Form3 admin = new Form3();
            admin.Show();
            admin.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void btn_Genre_Click(object sender, EventArgs e)
        {
            Form4 admin = new Form4();
            admin.Show();
            admin.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }
    }
}
