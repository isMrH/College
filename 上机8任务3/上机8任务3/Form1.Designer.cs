namespace 上机8任务3
{
    partial class ExplorerForm
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
            this.trvExplorer = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trvExplorer
            // 
            this.trvExplorer.Location = new System.Drawing.Point(-2, -1);
            this.trvExplorer.Name = "trvExplorer";
            this.trvExplorer.Size = new System.Drawing.Size(295, 267);
            this.trvExplorer.TabIndex = 0;
            // 
            // ExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.trvExplorer);
            this.Name = "ExplorerForm";
            this.Text = "资源管理器";
            this.Load += new System.EventHandler(this.ExplorerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvExplorer;
    }
}

