using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mobile.BLL;
using Mobile.Model;

namespace MobileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReFresh()
        {
            List<User> allbrand = BrandManager.GetALLBrand();
            dgvSelect.DataSource = allbrand;
        }
        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (BrandManager.IsExists(name) == true)
            {
                MessageBox.Show("品牌重复！");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            User u = new User();
            u.Name = txtName.Text.Trim();
            u.Remark = txtRemark.Text.Trim();

            int cnt = BrandManager.InsertBrand(u);
            if (cnt > 0)
            {
                ReFresh();
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dgvSelect.Visible = true;
            List<User> allbrand=BrandManager.GetALLBrand();
            dgvSelect.DataSource = allbrand;
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.BID = Convert.ToInt32(txtBid.Text);
            u.Name = txtName.Text;
            u.Remark = txtRemark.Text;

            int cnt = BrandManager.UpdateBrand(u);
            ReFresh();
        }

        private void dgvSelect_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSelect.SelectedRows.Count > 0)
            {
                txtBid.Text = this.dgvSelect.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = this.dgvSelect.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRemark.Text = this.dgvSelect.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSelect.SelectedRows.Count > 0)
            {
                string bid = dgvSelect.SelectedRows[0].Cells[0].Value.ToString();
                int cnt = BrandManager.DeleteBrand(bid);
                ReFresh();
            }
            else
            {
                MessageBox.Show("请先选中要删除的行");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvSelect.Visible = true;
            ReFresh();
        }
    }
}
