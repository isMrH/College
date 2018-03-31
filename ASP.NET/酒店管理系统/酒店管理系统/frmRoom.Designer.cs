namespace 酒店管理系统
{
    partial class frmRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoom));
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtBedNumber = new System.Windows.Forms.TextBox();
            this.lblBedNumber = new System.Windows.Forms.Label();
            this.txtGuestNumber = new System.Windows.Forms.TextBox();
            this.lblGuestNumber = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.cboState);
            this.grpInfo.Controls.Add(this.lblState);
            this.grpInfo.Controls.Add(this.txtBedNumber);
            this.grpInfo.Controls.Add(this.lblBedNumber);
            this.grpInfo.Controls.Add(this.txtGuestNumber);
            this.grpInfo.Controls.Add(this.lblGuestNumber);
            this.grpInfo.Controls.Add(this.txtPrice);
            this.grpInfo.Controls.Add(this.lblPrice);
            this.grpInfo.Controls.Add(this.cboType);
            this.grpInfo.Controls.Add(this.txtDescription);
            this.grpInfo.Controls.Add(this.lblDescription);
            this.grpInfo.Controls.Add(this.lblType);
            this.grpInfo.Controls.Add(this.txtNumber);
            this.grpInfo.Controls.Add(this.lblNumber);
            this.grpInfo.Location = new System.Drawing.Point(15, 345);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(559, 106);
            this.grpInfo.TabIndex = 7;
            this.grpInfo.TabStop = false;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "维修",
            "入住",
            "空闲"});
            this.cboState.Location = new System.Drawing.Point(476, 31);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(75, 20);
            this.cboState.TabIndex = 19;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(476, 16);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(29, 12);
            this.lblState.TabIndex = 18;
            this.lblState.Text = "状态";
            // 
            // txtBedNumber
            // 
            this.txtBedNumber.Location = new System.Drawing.Point(383, 31);
            this.txtBedNumber.Name = "txtBedNumber";
            this.txtBedNumber.Size = new System.Drawing.Size(72, 21);
            this.txtBedNumber.TabIndex = 17;
            // 
            // lblBedNumber
            // 
            this.lblBedNumber.AutoSize = true;
            this.lblBedNumber.Location = new System.Drawing.Point(381, 16);
            this.lblBedNumber.Name = "lblBedNumber";
            this.lblBedNumber.Size = new System.Drawing.Size(41, 12);
            this.lblBedNumber.TabIndex = 16;
            this.lblBedNumber.Text = "床位数";
            // 
            // txtGuestNumber
            // 
            this.txtGuestNumber.Location = new System.Drawing.Point(290, 32);
            this.txtGuestNumber.Name = "txtGuestNumber";
            this.txtGuestNumber.Size = new System.Drawing.Size(72, 21);
            this.txtGuestNumber.TabIndex = 15;
            // 
            // lblGuestNumber
            // 
            this.lblGuestNumber.AutoSize = true;
            this.lblGuestNumber.Location = new System.Drawing.Point(288, 17);
            this.lblGuestNumber.Name = "lblGuestNumber";
            this.lblGuestNumber.Size = new System.Drawing.Size(53, 12);
            this.lblGuestNumber.TabIndex = 14;
            this.lblGuestNumber.Text = "入住人数";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(197, 32);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(72, 21);
            this.txtPrice.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(195, 17);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 12);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "价格";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(101, 32);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(75, 20);
            this.cboType.TabIndex = 11;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(547, 21);
            this.txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 61);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(29, 12);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "描述";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(99, 17);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(53, 12);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "类型名称";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(8, 32);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(72, 21);
            this.txtNumber.TabIndex = 3;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(6, 17);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(41, 12);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "房间号";
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeID,
            this.类型名称,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column1});
            this.dgvRoom.Location = new System.Drawing.Point(13, 93);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowTemplate.Height = 23;
            this.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoom.Size = new System.Drawing.Size(560, 246);
            this.dgvRoom.TabIndex = 6;
            this.dgvRoom.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_RowEnter);
            // 
            // TypeID
            // 
            this.TypeID.DataPropertyName = "RoomId";
            this.TypeID.HeaderText = "ID";
            this.TypeID.Name = "TypeID";
            this.TypeID.Visible = false;
            // 
            // 类型名称
            // 
            this.类型名称.DataPropertyName = "RoomNumber";
            this.类型名称.HeaderText = "房间号";
            this.类型名称.Name = "类型名称";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BedNumber";
            this.Column2.HeaderText = "床位数";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "State";
            this.Column4.HeaderText = "状态";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GuestNumber";
            this.Column3.HeaderText = "入住人数";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Description";
            this.Column5.HeaderText = "描述";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TypeId";
            this.Column1.HeaderText = "TypeID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txtRoomNumber);
            this.groupBox1.Controls.Add(this.lblRoomNumber);
            this.groupBox1.Location = new System.Drawing.Point(15, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 42);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::酒店管理系统.Properties.Resources.查询选择;
            this.btnSelect.Location = new System.Drawing.Point(430, 11);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(129, 13);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(278, 21);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(60, 17);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(53, 12);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "房间号：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbUpdate,
            this.tsbDelete,
            this.tsbSave,
            this.tsbCancel,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(591, 35);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::酒店管理系统.Properties.Resources.新增;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(33, 32);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Image = global::酒店管理系统.Properties.Resources.修改;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(33, 32);
            this.tsbUpdate.Text = "修改";
            this.tsbUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::酒店管理系统.Properties.Resources.删除;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(33, 32);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::酒店管理系统.Properties.Resources.保存;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(33, 32);
            this.tsbSave.Text = "保存";
            this.tsbSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = global::酒店管理系统.Properties.Resources.取消;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(33, 32);
            this.tsbCancel.Text = "取消";
            this.tsbCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = global::酒店管理系统.Properties.Resources.退出;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(33, 32);
            this.tsbExit.Text = "退出";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 463);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房间信息设置";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtBedNumber;
        private System.Windows.Forms.Label lblBedNumber;
        private System.Windows.Forms.TextBox txtGuestNumber;
        private System.Windows.Forms.Label lblGuestNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}