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
    public partial class frmSort : Form
    {
        public frmSort()
        {
            InitializeComponent();
        }

        private void frmSort_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Book.bin", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Book> allBook = (List<Book>)bf.Deserialize(fs);
            fs.Close();
            allBook.Sort();
            foreach (Book book in allBook)
            {
                ListViewItem item = new ListViewItem(book.Name);
                item.SubItems.AddRange(new string[] { book.Author, book.Price.ToString() });
                lvBook.Items.Add(item);
            }
        }
    }
}
