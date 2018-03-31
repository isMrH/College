using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 上机7作业2
{
    public partial class frmMedal : Form
    {
        public frmMedal()
        {
            InitializeComponent();
        }

        List<Country> allcounter = new List<Country>();

        private void btnGoldPlate_Click(object sender, EventArgs e)
        {
            GoldPlateIComparer gold = new GoldPlateIComparer();
            allcounter.Sort(gold);
            lisShow.Items.Clear();
            int i = 1;
            foreach (Country country in allcounter)
            {
                lisShow.Items.Add(i + " " + country.Name + " 金牌数" + country.GoldPlate + "    奖牌数" + country.Medal);
                i++;
            }
        }

        private void btnMedal_Click(object sender, EventArgs e)
        {
            MedalIComparer medal = new MedalIComparer();
            allcounter.Sort(medal);
            lisShow.Items.Clear();
            int i = 1;
            foreach (Country country in allcounter)
            {
                lisShow.Items.Add(i + " " + country.Name + " 金牌数" + country.GoldPlate + "    奖牌数" + country.Medal);
                i++;
            }
        }

        private void frmMedal_Load(object sender, EventArgs e)
        {
            Country c1 = new Country("美国",36,110);
            allcounter.Add(c1);
            Country c2 = new Country("中国",51,100);
            allcounter.Add(c2);
            Country c3 = new Country("俄罗斯",51,100);
            allcounter.Add(c3);
            Country c4 = new Country("英国",19,47);
            allcounter.Add(c4);
            Country c5 = new Country("澳大利亚",14,45);
            allcounter.Add(c5);
            Country c6 = new Country("德国",16,41);
            allcounter.Add(c6);
            Country c7 = new Country("法国",7,40);
            allcounter.Add(c7);
            Country c8 = new Country("韩国",13,31);
            allcounter.Add(c8);
            Country c9 = new Country("意大利",8,28);
            allcounter.Add(c9);
            Country c10 = new Country("日本",9,25);
            allcounter.Add(c10);
            int i = 1;
            foreach (Country country in allcounter)
            {
                lisShow.Items.Add(i + " " + country.Name + " 金牌数" + country.GoldPlate + "    奖牌数" + country.Medal);
                i++;
            }

        }
    }
}
