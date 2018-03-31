using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 上机6作业1
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        List<Student> allStudent = new List<Student>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string number = txtNumber.Text.Trim();
            string sclass = txtClass.Text.Trim();
            Student stu= new Student(name, number, sclass);
            allStudent.Add(stu);
            cboName.Items.Add(name);
            MessageBox.Show("已录入" + allStudent.Count + "名学员信息");

            string message = "";
            for (int i = 0; i < allStudent.Count; i++)
            {
                message += allStudent[i].Name + "\t" + allStudent[i].SNumber + "\t" + allStudent[i].Sclass + "\r\n";
            }
            txtMessage.Text = message;
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboName.SelectedIndex;
            if (index == 0)
            {
                string message = "";
                for (int i = 0; i < allStudent.Count; i++)
                {
                    message += allStudent[i].Name + "\t" + allStudent[i].SNumber + "\t" + allStudent[i].Sclass + "\r\n";
                }
                txtMessage.Text = message;
            }
            else
            {
                txtMessage.Text = allStudent[index - 1].Name + "\t" + allStudent[index - 1].SNumber + "\t" + allStudent[index - 1].Sclass + "\r\n";
            }
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            cboName.Items.Add("全部");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = cboName.SelectedIndex;
            if (index == 0)
            {
                cboName.Items.Clear();
                cboName.Items.Add("全部");
                allStudent.Clear();
            }
            else 
            {
                allStudent.RemoveAt(index-1);
                cboName.Items.RemoveAt(index);
            }
            MessageBox.Show("删除成功！");
        }
    }
}
