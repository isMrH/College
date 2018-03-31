using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 联系人
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LinkMan lm = new LinkMan();
            lm.Name = txtName.Text.Trim();
            lm.Tel = txtTel.Text.Trim();
            lm.Email = txtEmail.Text.Trim();
            lm.Address = txtAddress.Text.Trim();
            
            int cnt=LinkManop.InsertLinkMan(lm);
            if (cnt > 0)
            {
                MessageBox.Show("提示","保存成功！",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            }
            else
            {
                Console.WriteLine("保存失败！");
            }
        }
    }
}
