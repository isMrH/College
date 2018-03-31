namespace 酒店管理系统
{
    partial class frmHotelManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotelManager));
            this.msiMenu = new System.Windows.Forms.MenuStrip();
            this.基础设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房间类型设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房间信息设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.业务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msiMenu
            // 
            this.msiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础设置ToolStripMenuItem,
            this.业务管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.msiMenu.Location = new System.Drawing.Point(0, 0);
            this.msiMenu.Name = "msiMenu";
            this.msiMenu.Size = new System.Drawing.Size(622, 24);
            this.msiMenu.TabIndex = 1;
            this.msiMenu.Text = "menuStrip1";
            // 
            // 基础设置ToolStripMenuItem
            // 
            this.基础设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.房间类型设置ToolStripMenuItem,
            this.房间信息设置ToolStripMenuItem});
            this.基础设置ToolStripMenuItem.Name = "基础设置ToolStripMenuItem";
            this.基础设置ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.基础设置ToolStripMenuItem.Text = "基础设置";
            // 
            // 房间类型设置ToolStripMenuItem
            // 
            this.房间类型设置ToolStripMenuItem.Name = "房间类型设置ToolStripMenuItem";
            this.房间类型设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.房间类型设置ToolStripMenuItem.Text = "房间类型设置";
            this.房间类型设置ToolStripMenuItem.Click += new System.EventHandler(this.房间类型设置ToolStripMenuItem_Click);
            // 
            // 房间信息设置ToolStripMenuItem
            // 
            this.房间信息设置ToolStripMenuItem.Name = "房间信息设置ToolStripMenuItem";
            this.房间信息设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.房间信息设置ToolStripMenuItem.Text = "房间信息设置";
            this.房间信息设置ToolStripMenuItem.Click += new System.EventHandler(this.房间信息设置ToolStripMenuItem_Click);
            // 
            // 业务管理ToolStripMenuItem
            // 
            this.业务管理ToolStripMenuItem.Name = "业务管理ToolStripMenuItem";
            this.业务管理ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.业务管理ToolStripMenuItem.Text = "业务管理";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // frmHotelManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 497);
            this.Controls.Add(this.msiMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msiMenu;
            this.Name = "frmHotelManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msiMenu.ResumeLayout(false);
            this.msiMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msiMenu;
        private System.Windows.Forms.ToolStripMenuItem 基础设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房间类型设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房间信息设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 业务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;

    }
}

