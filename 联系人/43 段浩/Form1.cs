using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<FriendType> AllType = new List<FriendType>();

            cboType.DataSource = FriendTypeOp.GetAllFridens();
            cboType.DisplayMember = "Typename";
            cboType.ValueMember = "Fid";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = FriendsOp.IxExist(txtName.Text);

            if (result)
            {
                MessageBox.Show("联系人" + txtName.Text + "已存在！\n","提示",MessageBoxButtons.OK);
            }
            else
            {
                Friends friend = new Friends();
                friend.Name = txtName.Text;
                friend.Fid = Convert.ToInt32(cboType.SelectedValue);
                friend.Tel = txtTel.Text;
                friend.Email = txtEmail.Text;
                friend.Address = txtAdress.Text;

                int cnt = FriendsOp.InsertFriend(friend);
                if (cnt > 0)
                {
                    if (MessageBox.Show("保存成功，是否继续", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtName.Text = "";
                        txtAdress.Text = "";
                        txtEmail.Text = "";
                        txtTel.Text = "";
                        cboType.SelectedIndex = -1;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("保存失败，是否继续","提示");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
