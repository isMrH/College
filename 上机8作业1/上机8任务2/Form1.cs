using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace 上机8任务2
{
    public partial class GameInfoForm : Form
    {
        public GameInfoForm()
        {
            InitializeComponent();
        }

        public static string path = "";

        private void btnSave_Click(object sender, EventArgs e)
        {
            path = txtPath.Text.Trim();
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            frmText text = new frmText();
            text.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string filepath = txtPath.Text;
            FileStream fs = new FileStream(filepath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string name = txtName.Text;
            bool isfind = false;
            string oneline = "";
            while(!sr.EndOfStream)
            {
                oneline = sr.ReadLine();
                string gamename = oneline.Substring(5);
                if (gamename == name)
                {
                    isfind = true;
                    oneline = sr.ReadLine();
                    txtType.Text = oneline.Substring(5);
                    oneline = sr.ReadLine();
                    txtTime.Text = oneline.Substring(5);
                    isfind = true;
                    break;
                }
            }
            if (isfind == false)
            {
                MessageBox.Show("文件中没有此游戏信息！");
            }

            sr.Close();
            fs.Close();

        
        }
    }
}
