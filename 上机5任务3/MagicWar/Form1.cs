using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MagicWar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1, 3);
            MagicAnimal magicAnimal = MagicAnimalFactory.CreateMagicAnimal(num);
            lblRandom.Text = magicAnimal.Type;
            txtMessage.Text = magicAnimal.Show();
        }
    }
}
