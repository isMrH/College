using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotBooksWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MyBookShop.HotBooksWebService hotBooksWebService = new MyBookShop.HotBooksWebService();
            string[] booksName = hotBooksWebService.GetHotBooks(txtBookName.Text.Trim());
            foreach (string bookName in booksName)
            {
                lbBooksName.Items.Add(bookName);
            }
        }
    }
}