namespace 上机6作业2
{
    partial class frmSelect
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReNumber = new System.Windows.Forms.TextBox();
            this.lblLook = new System.Windows.Forms.Label();
            this.txtLook = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.grpAdd.SuspendLayout();
            this.grpSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(66, 20);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(136, 21);
            this.txtNumber.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(19, 23);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(29, 12);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "账号";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 21);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "账号";
            // 
            // txtReNumber
            // 
            this.txtReNumber.Location = new System.Drawing.Point(63, 20);
            this.txtReNumber.Name = "txtReNumber";
            this.txtReNumber.Size = new System.Drawing.Size(136, 21);
            this.txtReNumber.TabIndex = 4;
            // 
            // lblLook
            // 
            this.lblLook.AutoSize = true;
            this.lblLook.Location = new System.Drawing.Point(43, 185);
            this.lblLook.Name = "lblLook";
            this.lblLook.Size = new System.Drawing.Size(29, 12);
            this.lblLook.TabIndex = 7;
            this.lblLook.Text = "查看";
            // 
            // txtLook
            // 
            this.txtLook.Location = new System.Drawing.Point(99, 182);
            this.txtLook.Name = "txtLook";
            this.txtLook.Size = new System.Drawing.Size(353, 21);
            this.txtLook.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(127, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(124, 93);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.lblName);
            this.grpAdd.Controls.Add(this.txtName);
            this.grpAdd.Controls.Add(this.lblNumber);
            this.grpAdd.Controls.Add(this.txtNumber);
            this.grpAdd.Location = new System.Drawing.Point(15, 18);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(216, 131);
            this.grpAdd.TabIndex = 10;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "添加用户";
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.btnSelect);
            this.grpSelect.Controls.Add(this.label3);
            this.grpSelect.Controls.Add(this.txtReNumber);
            this.grpSelect.Location = new System.Drawing.Point(253, 18);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(216, 133);
            this.grpSelect.TabIndex = 11;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "查询用户";
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 230);
            this.Controls.Add(this.grpSelect);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.lblLook);
            this.Controls.Add(this.txtLook);
            this.Name = "frmSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找用户";
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReNumber;
        private System.Windows.Forms.Label lblLook;
        private System.Windows.Forms.TextBox txtLook;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.GroupBox grpSelect;
    }
}

