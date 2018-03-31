namespace 上机7作业2
{
    partial class frmMedal
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
            this.btnGoldPlate = new System.Windows.Forms.Button();
            this.btnMedal = new System.Windows.Forms.Button();
            this.lisShow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGoldPlate
            // 
            this.btnGoldPlate.Location = new System.Drawing.Point(247, 12);
            this.btnGoldPlate.Name = "btnGoldPlate";
            this.btnGoldPlate.Size = new System.Drawing.Size(75, 23);
            this.btnGoldPlate.TabIndex = 0;
            this.btnGoldPlate.Text = "金牌榜";
            this.btnGoldPlate.UseVisualStyleBackColor = true;
            this.btnGoldPlate.Click += new System.EventHandler(this.btnGoldPlate_Click);
            // 
            // btnMedal
            // 
            this.btnMedal.Location = new System.Drawing.Point(247, 56);
            this.btnMedal.Name = "btnMedal";
            this.btnMedal.Size = new System.Drawing.Size(75, 23);
            this.btnMedal.TabIndex = 1;
            this.btnMedal.Text = "奖牌榜";
            this.btnMedal.UseVisualStyleBackColor = true;
            this.btnMedal.Click += new System.EventHandler(this.btnMedal_Click);
            // 
            // lisShow
            // 
            this.lisShow.FormattingEnabled = true;
            this.lisShow.ItemHeight = 12;
            this.lisShow.Location = new System.Drawing.Point(12, 12);
            this.lisShow.Name = "lisShow";
            this.lisShow.Size = new System.Drawing.Size(226, 268);
            this.lisShow.TabIndex = 2;
            // 
            // frmMedal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 295);
            this.Controls.Add(this.lisShow);
            this.Controls.Add(this.btnMedal);
            this.Controls.Add(this.btnGoldPlate);
            this.Name = "frmMedal";
            this.Text = "奥运会奖牌榜";
            this.Load += new System.EventHandler(this.frmMedal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoldPlate;
        private System.Windows.Forms.Button btnMedal;
        private System.Windows.Forms.ListBox lisShow;
    }
}

