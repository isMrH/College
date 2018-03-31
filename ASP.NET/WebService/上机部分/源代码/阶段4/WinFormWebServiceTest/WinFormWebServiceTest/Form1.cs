using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormWebServiceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MyBookShop.MyWebService myService = new MyBookShop.MyWebService();
            string[] keyWords = myService.GetHotSearchByKeywords(txtKeyWord.Text.Trim());
            foreach (string keyWord in keyWords)
            {
                lbKeyWords.Items.Add(keyWord);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}