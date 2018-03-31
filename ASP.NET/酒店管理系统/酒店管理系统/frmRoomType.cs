using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelManager.BLL;
using HotelManager.Model;

namespace 酒店管理系统
{
    public partial class frmRoomType : Form
    {
        public static string IsAddBed;
        public static string op;
        public static bool p;
        public static int ID;
        public frmRoomType()
        {
            InitializeComponent();
        }
        private void ReFresh()
        {
            List<RoomType> allType = TypeManager.GetALLType();
            dgvType.DataSource = allType;
            
        }
        private void frmRoomType_Load(object sender, EventArgs e)
        {
            ReFresh();
            this.Height = 380;
            
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            op = "Add";
            this.Height = 490;
            txtTypeName.Clear();
            txtTypeName.Enabled = true;
            txtPrice.Clear();
            txtPrice.Enabled = true;
            txtRemark.Clear();
            txtRemark.Enabled = true;
            txtAddBedPrice.Clear();
            chkIsAddBed.Checked = false;
            txtAddBedPrice.Text = "0";
          
        }

        private void chkIsAddBed_CheckedChanged(object sender, EventArgs e)
        {
            RoomType rt = new RoomType();
            if (chkIsAddBed.Checked)
            {
                txtAddBedPrice.Enabled = true;
                txtAddBedPrice.Clear();
                IsAddBed = "是";
                
            }
            else
            {
                txtAddBedPrice.Enabled = false;
                txtAddBedPrice.Text = "0";
                IsAddBed = "否";
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            RoomType rt = new RoomType();
            try
            {
                rt.TypeName = txtTypeName.Text.Trim();
                rt.TypePrice = Int32.Parse(txtPrice.Text.Trim());
                rt.Remark = txtRemark.Text.Trim();
                rt.AddBedPrice = Int32.Parse(txtAddBedPrice.Text.Trim());
                rt.IsAddBed = IsAddBed;
                rt.TypeId = ID;
                if (rt.TypeName == "" || rt.Remark == "")
                {
                    p = false;
                    MessageBox.Show("请填入非空数据！");
                }
                else
                {
                    p = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的数据！");
                p = false;
            }
            if (op == "Update" && p == true)
            {
                int cnt = TypeManager.UpdateType(rt);
               
                if (cnt > 0)
                {
                    ReFresh();
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
                
            }
            else if (op == "Add" && p == true)
            {
                int cnt = TypeManager.InsertType(rt);
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
      
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.Height = 380;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgvType.SelectedRows.Count > 0)
            {
                int typeid = Convert.ToInt32(dgvType.SelectedRows[0].Cells[0].Value.ToString());
                if(MessageBox.Show("确定要删除吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    bool result = TypeManager.IdExitRoomByTypeId(typeid);
                    if (result == true)
                    {
                        MessageBox.Show("该类型有相关记录，不能删除！");
                    }
                    else
                    {
                        int cnt = TypeManager.DeleteType(typeid);
                        ReFresh();
                    }                 
                    
                }
            }
            else
            {
                MessageBox.Show("请先选中要删除的行!");
            }
        }

        private void dgvType_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvType.SelectedRows.Count > 0)
            {
                this.Height = 490;
                ID = Convert.ToInt32(this.dgvType.Rows[e.RowIndex].Cells[0].Value);
                txtTypeName.Text = this.dgvType.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPrice.Text = this.dgvType.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (this.dgvType.Rows[e.RowIndex].Cells[3].Value.ToString() == "是")
                {
                    chkIsAddBed.Checked = true;
                }
                else
                {
                    chkIsAddBed.Checked = false;
                }
                txtAddBedPrice.Text = this.dgvType.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtRemark.Text = this.dgvType.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTypeName.Enabled = false;
                txtPrice.Enabled = false;
                chkIsAddBed.Enabled = false;
                txtAddBedPrice.Enabled = false;
                txtRemark.Enabled = false;
                
            }
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            op = "Update";
            this.Height = 490;
            txtTypeName.Clear();
            txtTypeName.Enabled = true;
            txtPrice.Clear();
            txtPrice.Enabled = true;
            txtRemark.Clear();
            txtRemark.Enabled = true;
            txtAddBedPrice.Clear();
            chkIsAddBed.Checked = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string typename = txtType.Text.Trim();
            if (typename == "")
            {
                ReFresh();
            }
            else
            {
                List<RoomType> selectType = TypeManager.SelectType(typename);
                dgvType.DataSource = selectType;
            }
           
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
