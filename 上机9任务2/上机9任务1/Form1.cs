using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace 上机9任务1
{
    public partial class frmBookInfo : Form
    {
        public frmBookInfo()
        {
            InitializeComponent();
        }

        List<Book> allBook = new List<Book>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string author = txtAuthor.Text.Trim();
            double price = double.Parse(txtPrice.Text.Trim());
            Book book = new Book(name, author, price);
            allBook.Add(book);
            MessageBox.Show("添加成功！");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Book.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, allBook);
            fs.Close();
            MessageBox.Show("以保存。");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            frmSort frmsort = new frmSort();
            frmsort.Show();
        }
    }
}
