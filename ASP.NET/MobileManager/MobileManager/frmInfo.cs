using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mobile.Model;
using Mobile.BLL;

namespace MobileManager
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int bid = int.Parse(cboBrand.SelectedValue.ToString());
            string mytype = txtType.Text.Trim();
            string os = txtOs.Text.Trim();
            string size = txtSize.Text.Trim();
            string weight = txtWeight.Text.Trim();
            string date = dtpTime.Text.Trim();
            float unitprice = float.Parse(txtRemark.Text);
            int remain = int.Parse(txtRemark.Text);
            string isIntelligent = "否";
            if (checkBox1.Checked)
            {
                isIntelligent = "是";
            }
            if (mytype == "" || os == "" || size == "" || date == "" || weight == "" || txtUnitprice.Text == "" || txtRemark.Text == "")
            {
                MessageBox.Show("请填写完整信息！");
            }
            Info newinfo = new Info();
            newinfo.Bid = bid;
            newinfo.OS = os;
            newinfo.MType = mytype;
            newinfo.ScreenSize = size;
            newinfo.Weights = weight;
            newinfo.DateOfListing = DateTime.Parse(date);
            newinfo.Remain = remain;
            newinfo.IsIntelligent = isIntelligent;
            newinfo.Unitprice = unitprice;
            int cnt = InfoManagers.InsertInfo(newinfo);
            if (cnt > 0)
            {
                MessageBox.Show("插入成功！");
            }
            else
            {
                MessageBox.Show("插入失败！");
            }
        }
    }
}
