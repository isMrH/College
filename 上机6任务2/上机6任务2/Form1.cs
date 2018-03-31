using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 上机6任务2
{
    public partial class frmStudnet : Form
    {
        public frmStudnet()
        {
            InitializeComponent();
        }

        List<Student> allStudent=new List<Student>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name=txtName.Text.Trim();
            string number=txtNumber.Text.Trim();
            string sclass=txtClass.Text.Trim();
            Student stu=new Student(name,number,sclass);
            allStudent.Add(stu);
            MessageBox.Show("已录入"+allStudent.Count+"名学员信息");

            string message="";
            for(int i=0;i<allStudent.Count;i++)
            {
                 message += allStudent[i].Name + "\t" + allStudent[i].SNumber + "\t" + allStudent[i].Sclass+"\r\n";
            }
            txtMessage.Text = message;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
