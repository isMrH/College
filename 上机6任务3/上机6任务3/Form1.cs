using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 上机6任务3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string,City> allCity = new Dictionary<string, City>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string province = txtProvince.Text.Trim();
            string name = txtName.Text.Trim();
            string code = txtCode.Text.Trim();

            City city = new City(name, province, code);
            allCity.Add(code, city);
            lstInfo.Items.Add(code);
            MessageBox.Show("添加成功！");
        }

        private void lstInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string code = lstInfo.SelectedItem.ToString();
            txtMessage.Text = "省份：" + allCity[code].Province + "省会：" + allCity[code].Name;
        }
    }
}
