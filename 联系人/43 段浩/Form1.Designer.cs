namespace 练习
{
    partial class Form1
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
            this.lblemail = new System.Windows.Forms.Label();
            this.gpbBitian = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.gpbXuantian = new System.Windows.Forms.GroupBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gpbBitian.SuspendLayout();
            this.gpbXuantian.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(42, 35);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 12);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email";
            // 
            // gpbBitian
            // 
            this.gpbBitian.Controls.Add(this.txtTel);
            this.gpbBitian.Controls.Add(this.txtName);
            this.gpbBitian.Controls.Add(this.cboType);
            this.gpbBitian.Controls.Add(this.lblTel);
            this.gpbBitian.Controls.Add(this.lblName);
            this.gpbBitian.Controls.Add(this.lblType);
            this.gpbBitian.Location = new System.Drawing.Point(57, 37);
            this.gpbBitian.Name = "gpbBitian";
            this.gpbBitian.Size = new System.Drawing.Size(348, 169);
            this.gpbBitian.TabIndex = 1;
            this.gpbBitian.TabStop = false;
            this.gpbBitian.Text = "必填项";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(117, 121);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(169, 21);
            this.txtTel.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 21);
            this.txtName.TabIndex = 4;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(117, 25);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(169, 20);
            this.cboType.TabIndex = 3;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(18, 124);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(53, 12);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "联系电话";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(42, 28);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 12);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "类型";
            // 
            // gpbXuantian
            // 
            this.gpbXuantian.Controls.Add(this.txtAdress);
            this.gpbXuantian.Controls.Add(this.txtEmail);
            this.gpbXuantian.Controls.Add(this.lblAdress);
            this.gpbXuantian.Controls.Add(this.lblemail);
            this.gpbXuantian.Location = new System.Drawing.Point(57, 251);
            this.gpbXuantian.Name = "gpbXuantian";
            this.gpbXuantian.Size = new System.Drawing.Size(353, 107);
            this.gpbXuantian.TabIndex = 2;
            this.gpbXuantian.TabStop = false;
            this.gpbXuantian.Text = "选填项";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(117, 71);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(169, 21);
            this.txtAdress.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(24, 74);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(53, 12);
            this.lblAdress.TabIndex = 1;
            this.lblAdress.Text = "家庭住址";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(264, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(359, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 432);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gpbXuantian);
            this.Controls.Add(this.gpbBitian);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbBitian.ResumeLayout(false);
            this.gpbBitian.PerformLayout();
            this.gpbXuantian.ResumeLayout(false);
            this.gpbXuantian.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.GroupBox gpbBitian;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.GroupBox gpbXuantian;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}

