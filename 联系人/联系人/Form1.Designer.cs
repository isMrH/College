namespace 联系人
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpChoice = new System.Windows.Forms.GroupBox();
            this.grpGotta = new System.Windows.Forms.GroupBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.grpChoice.SuspendLayout();
            this.grpGotta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(70, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(51, 26);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 12);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "类型";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(27, 91);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(53, 12);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "联系电话";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(45, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 12);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(27, 63);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(53, 12);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "家庭住址";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(91, 88);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(172, 21);
            this.txtTel.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(91, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 21);
            this.txtEmail.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(91, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(172, 21);
            this.txtAddress.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(216, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "关闭";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grpChoice
            // 
            this.grpChoice.Controls.Add(this.txtAddress);
            this.grpChoice.Controls.Add(this.txtEmail);
            this.grpChoice.Controls.Add(this.lblAddress);
            this.grpChoice.Controls.Add(this.lblEmail);
            this.grpChoice.Location = new System.Drawing.Point(32, 155);
            this.grpChoice.Name = "grpChoice";
            this.grpChoice.Size = new System.Drawing.Size(297, 105);
            this.grpChoice.TabIndex = 12;
            this.grpChoice.TabStop = false;
            this.grpChoice.Text = "选填项";
            // 
            // grpGotta
            // 
            this.grpGotta.Controls.Add(this.cboType);
            this.grpGotta.Controls.Add(this.txtTel);
            this.grpGotta.Controls.Add(this.txtName);
            this.grpGotta.Controls.Add(this.lblTel);
            this.grpGotta.Controls.Add(this.lblName);
            this.grpGotta.Controls.Add(this.lblType);
            this.grpGotta.Location = new System.Drawing.Point(32, 21);
            this.grpGotta.Name = "grpGotta";
            this.grpGotta.Size = new System.Drawing.Size(296, 124);
            this.grpGotta.TabIndex = 13;
            this.grpGotta.TabStop = false;
            this.grpGotta.Text = "必填项";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(91, 23);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(172, 20);
            this.cboType.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 320);
            this.Controls.Add(this.grpGotta);
            this.Controls.Add(this.grpChoice);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通讯录";
            this.grpChoice.ResumeLayout(false);
            this.grpChoice.PerformLayout();
            this.grpGotta.ResumeLayout(false);
            this.grpGotta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpChoice;
        private System.Windows.Forms.GroupBox grpGotta;
        private System.Windows.Forms.ComboBox cboType;
    }
}

