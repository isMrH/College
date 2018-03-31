using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 上机6作业2
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        Dictionary<string, Player> allPlayer = new Dictionary<string, Player>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string num = txtNumber.Text.Trim();
            string name = txtName.Text.Trim();
            Player player = new Player(num, name);
            allPlayer.Add(num, player);
            MessageBox.Show("已添加用户"+allPlayer.Count+"名");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string num = txtReNumber.Text.Trim();

            for (int index = 0; index < allPlayer.Count; index++)
            {

                if (num == allPlayer[num].Number)
                {
                    txtLook.Text = "ID：" + allPlayer[num].Number + "   Name：" + allPlayer[num].Name;
                }
                else
                {
                    MessageBox.Show("此账号不存在！");
                }
            }

        }
    }
}
