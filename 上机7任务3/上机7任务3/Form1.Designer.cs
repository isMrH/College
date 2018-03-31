namespace 上机7任务3
{
    partial class frmGame
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSell = new System.Windows.Forms.Button();
            this.btnScore = new System.Windows.Forms.Button();
            this.lisShow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(36, 231);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(102, 23);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "按销售量排序";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(154, 231);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(102, 23);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "按玩家评分排序";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // lisShow
            // 
            this.lisShow.FormattingEnabled = true;
            this.lisShow.ItemHeight = 12;
            this.lisShow.Location = new System.Drawing.Point(12, 9);
            this.lisShow.Name = "lisShow";
            this.lisShow.Size = new System.Drawing.Size(268, 208);
            this.lisShow.TabIndex = 2;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.lisShow);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnSell);
            this.Name = "frmGame";
            this.Text = "2009游戏排行";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.ListBox lisShow;
    }
}

