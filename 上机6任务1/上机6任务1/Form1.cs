using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace 上机6任务1
{
    public partial class AircraftCarrierForm : Form
    {
        public AircraftCarrierForm()
        {
            InitializeComponent();
        }

        ArrayList allShip = new ArrayList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            allShip.Add(name);
            cboAll.Items.Add(name);
            MessageBox.Show("共有"+allShip.Count+"艘航空母舰");
        }

        private void cboAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboAll.SelectedIndex;
            if (index == 0)
            {
                string message = "";
                for (int i = 0; i < allShip.Count; i++)
                {
                    message += allShip[i].ToString() + "\r\n";
                }
                txtLook.Text = message;
            }
            else 
            {
                txtLook.Text = allShip[index - 1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = cboAll.SelectedIndex;
            if (index == 0)
            {
                cboAll.Items.Clear();
                cboAll.Items.Add("全部");
                allShip.Clear();
            }
            else 
            {
                allShip.RemoveAt(index - 1);
                cboAll.Items.RemoveAt(index);
            }
            MessageBox.Show("删除成功！");
        }
    }
}
