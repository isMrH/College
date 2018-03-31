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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<FriendType> AllType = FriendTypeOp.GetAllFridens();

            FriendType type1 = new FriendType();
            type1.Fid = 0;
            type1.Typename = "所有";
            AllType.Insert(0, type1);

            cboType.DataSource = AllType;
            cboType.DisplayMember = "Typename";
            cboType.ValueMember = "Fid";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string typeid = cboType.SelectedValue.ToString();
            List<Friends> friend = FriendsOp.GetFriendsByTypeId(typeid);
            dgvAllFriends.DataSource = friend;
        }
    }
}
