using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 上机8任务2
{
    public partial class frmText : Form
    {
        public frmText()
        {
            InitializeComponent();
        }

        private void frmText_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(GameInfoForm.path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string message = sr.ReadToEnd();
            txtMessage.Text = message;
            sr.Close();
            fs.Close();
  

        }
    }
}
