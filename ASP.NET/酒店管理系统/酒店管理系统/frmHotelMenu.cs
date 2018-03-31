using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 酒店管理系统
{
    public partial class frmHotelManager : Form
    {
        public frmHotelManager()
        {
            InitializeComponent();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 房间类型设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoomType frmroomtype = new frmRoomType();
            frmroomtype.MdiParent = this;
            frmroomtype.Show();
        }

        private void 房间信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoom frmroom = new frmRoom();
            frmroom.MdiParent = this;
            frmroom.Show();
        }
    }
}
