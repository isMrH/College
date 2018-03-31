using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 上机7任务3
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        List<Game> allGame = new List<Game>();
        private void btnSell_Click(object sender, EventArgs e)
        {
            SellIComparer sell = new SellIComparer();
            allGame.Sort(sell); //排序
            lisShow.Items.Clear();
            int i = 1;
            foreach (Game game in allGame)
            {
                lisShow.Items.Add(i+" "+game.Name+" "+game.Sell+"套"+game.Score+"分");
                i++;
            }
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            ScoreIComparer score = new ScoreIComparer();
            allGame.Sort(score); //排序
            lisShow.Items.Clear();
            int i = 1;
            foreach (Game game in allGame)
            {
                lisShow.Items.Add(i + " " + game.Name + " " + game.Sell + "套" + game.Score + "分");
                i++;
            }
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            Game g1 = new Game("《模拟人生2：厨房与浴室》",112022,8.7);
            allGame.Add(g1);
            Game g2 = new Game("《模拟人生2：公寓生活》",91011,8.2);
            allGame.Add(g2);
            Game g3 = new Game("《模拟人生2：闲暇时光》",89725,8.4);
            allGame.Add(g3);
            Game g4= new Game("《孢子生物编辑器》",79010,8.2);
            allGame.Add(g4);
            Game g5 = new Game("《模拟人生：孤岛物语》",77561 ,8.8);
            allGame.Add(g5);
            Game g6 = new Game("《太阳帝国的原罪》",63220 ,9);
            allGame.Add(g6);
            Game g7 = new Game("《孢子》",61375 ,9.7);
            allGame.Add(g7);
            Game g8 = new Game("《柯南时代：西伯莱人大冒险》", 60715,9.3);
            allGame.Add(g8);
            Game g9 = new Game("《战锤OL》", 60377,9.2);
            allGame.Add(g9);
            Game g10 = new Game("《战锤40K战争黎明》", 58207,8.7);
            allGame.Add(g10);
            int i = 1;
            foreach (Game game in allGame)
            {
                lisShow.Items.Add(i + " " + game.Name + " " + game.Sell + "套 " + game.Score + "分");
                i++;
            }
        }
    }
}
