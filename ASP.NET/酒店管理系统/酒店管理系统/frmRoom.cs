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
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }
        private static int op;
        private static int roomid;
        private void ReFresh()
        {
            List<Room> allRoom = RoomManager.GetALLRoom();
            dgvRoom.DataSource = allRoom;
        }
        private void Star()
        {
            tsbAdd.Enabled = true;
            tsbDelete.Enabled = false;
            tsbCancel.Enabled = false;
            tsbSave.Enabled = false;
            tsbUpdate.Enabled = false;
            tsbExit.Enabled = true;
            grpInfo.Enabled = false;
        }
        private void Clear()
        {
            txtBedNumber.Clear();
            txtDescription.Clear();
            txtNumber.Clear();
            txtPrice.Clear();
            txtGuestNumber.Clear();
            cboType.Text = "";
            cboState.Text = "";
        }
        private void frmRoom_Load(object sender, EventArgs e)
        {
            ReFresh();
            Star();
            
            this.cboType.DataSource = TypeManager.GetALLType();
            
            this.cboType.DisplayMember = "typename";
            this.cboType.ValueMember = "typeid";
            
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            Star();
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            op = 1;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            grpInfo.Enabled = true;
            Clear();
           
        }

        private void dgvRoom_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRoom.SelectedRows.Count > 0)
            {
                tsbAdd.Enabled = false;
                tsbDelete.Enabled = true;
                tsbCancel.Enabled = true;
                tsbSave.Enabled = true;
                tsbUpdate.Enabled = true;
                grpInfo.Enabled = false;

                int ID = Convert.ToInt32(this.dgvRoom.Rows[e.RowIndex].Cells[0].Value);
                txtNumber.Text = this.dgvRoom.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtBedNumber.Text = this.dgvRoom.Rows[e.RowIndex].Cells[2].Value.ToString();
                cboState.Text= this.dgvRoom.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtGuestNumber.Text = this.dgvRoom.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDescription.Text = this.dgvRoom.Rows[e.RowIndex].Cells[3].Value.ToString();
                int TypeID = Convert.ToInt32(this.dgvRoom.Rows[e.RowIndex].Cells[6].Value);
                
                cboType.Text=RoomManager.GetRoomByTypeId(TypeID).TypeName.ToString();
                txtPrice.Text = RoomManager.GetRoomByTypeId(TypeID).TypePrice.ToString();
                
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            int number;
            int GuestNumber;
            int BedNumber;
        
            if (!int.TryParse(txtNumber.Text, out number))
            {
                MessageBox.Show("请输入正确的房间号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPrice.Text == "")
            {

                MessageBox.Show("请选择房间类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboType.Text == "")
            {
                MessageBox.Show("请选择房间类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                r.TypeId = Convert.ToInt32(cboType.SelectedValue.ToString());
            }
            
            if (!int.TryParse(txtGuestNumber.Text, out GuestNumber))
            {
                MessageBox.Show("请输入正确的入住人数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBedNumber.Text, out BedNumber))
            {
                MessageBox.Show("请输入正确的床位数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (cboState.Text=="")
            {
                MessageBox.Show("请选择房间状态！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                r.State = cboState.Text;
              

            }

            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("请填写描述！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                r.Description = txtDescription.Text;
                
            }
            
            r.RoomNumber = number;
            r.BedNumber = BedNumber;
            
            if (op==1)
            {
                int cnt = RoomManager.InsertRoom(r);
                ReFresh();
                MessageBox.Show("添加成功！");
                return;
            }
            if (op == 2)
            {
                int cnt = RoomManager.UpdateRoom(r);
                ReFresh();
                MessageBox.Show("修改成功！");
                return;
            }
           
            
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            op = 2;
            grpInfo.Enabled = true;
            
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedValue.ToString() != "HotelManager.Model.RoomType")
            {
                string typeid = cboType.SelectedValue.ToString();
                int tid = int.Parse(typeid);
                txtPrice.Text = TypeManager.GetTypeByID(tid).ToString();
            }            
            
        }
    }
}
