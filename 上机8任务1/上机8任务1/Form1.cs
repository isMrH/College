using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 上机8任务1
{
    public partial class GameInfoForm : Form
    {
        public GameInfoForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text.Trim();

            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string game = "游戏名称：" + txtName.Text.Trim();
            sw.WriteLine(game);
            game = "游戏类型：" + txtType.Text.Trim();
            sw.WriteLine(game);
            game = "发行时间:" + txtTime.Text.Trim();
            sw.WriteLine(game);

            sw.Close();
            fs.Close();
            MessageBox.Show("保存成功！");
        }
    }
}
