namespace JINSHIN.Finance.AccountSystem.FrmControl.Business.Accounts
{
    partial class FrmRecMgt
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
            this.dgData = new System.Windows.Forms.DataGridView();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.lblmoney = new System.Windows.Forms.Label();
            this.lblttlamt = new System.Windows.Forms.Label();
            this.lbltitle02 = new System.Windows.Forms.Label();
            this.lblaccAffairs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.btnMQuery = new System.Windows.Forms.Button();
            this.btnMUpdate = new System.Windows.Forms.Button();
            this.btnMDelete = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.flowcontrol = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMAdd = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.plSearch = new System.Windows.Forms.Panel();
            this.lblNoData01 = new System.Windows.Forms.Label();
            this.gbHolidayMgt = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.flowcontrol.SuspendLayout();
            this.plSearch.SuspendLayout();
            this.gbHolidayMgt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.AllowUserToResizeColumns = false;
            this.dgData.AllowUserToResizeRows = false;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(6, 181);
            this.dgData.MultiSelect = false;
            this.dgData.Name = "dgData";
            this.dgData.ReadOnly = true;
            this.dgData.RowTemplate.Height = 24;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(1224, 345);
            this.dgData.TabIndex = 57;
            this.dgData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgData_CellFormatting);
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeleteAcc.Location = new System.Drawing.Point(619, 3);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(148, 41);
            this.btnDeleteAcc.TabIndex = 56;
            this.btnDeleteAcc.Text = "更新帳務";
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // lblmoney
            // 
            this.lblmoney.AutoSize = true;
            this.lblmoney.ForeColor = System.Drawing.Color.Red;
            this.lblmoney.Location = new System.Drawing.Point(1029, 43);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(94, 19);
            this.lblmoney.TabIndex = 58;
            this.lblmoney.Text = "                 ";
            // 
            // lblttlamt
            // 
            this.lblttlamt.AutoSize = true;
            this.lblttlamt.Location = new System.Drawing.Point(969, 43);
            this.lblttlamt.Name = "lblttlamt";
            this.lblttlamt.Size = new System.Drawing.Size(52, 19);
            this.lblttlamt.TabIndex = 57;
            this.lblttlamt.Text = "小計:";
            // 
            // lbltitle02
            // 
            this.lbltitle02.AutoSize = true;
            this.lbltitle02.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle02.Location = new System.Drawing.Point(249, 24);
            this.lbltitle02.Name = "lbltitle02";
            this.lbltitle02.Size = new System.Drawing.Size(66, 19);
            this.lbltitle02.TabIndex = 52;
            this.lbltitle02.Text = "付款人";
            this.lbltitle02.Click += new System.EventHandler(this.lbltitle02_Click);
            // 
            // lblaccAffairs
            // 
            this.lblaccAffairs.AutoSize = true;
            this.lblaccAffairs.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblaccAffairs.Location = new System.Drawing.Point(31, 24);
            this.lblaccAffairs.Name = "lblaccAffairs";
            this.lblaccAffairs.Size = new System.Drawing.Size(47, 19);
            this.lblaccAffairs.TabIndex = 53;
            this.lblaccAffairs.Text = "編號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(503, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "付款公司";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNo.Location = new System.Drawing.Point(90, 21);
            this.txtNo.Multiline = true;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(138, 26);
            this.txtNo.TabIndex = 1;
            this.txtNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNo_KeyUp);
            // 
            // btnMQuery
            // 
            this.btnMQuery.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMQuery.Location = new System.Drawing.Point(784, 13);
            this.btnMQuery.Name = "btnMQuery";
            this.btnMQuery.Size = new System.Drawing.Size(148, 41);
            this.btnMQuery.TabIndex = 56;
            this.btnMQuery.Text = "查詢";
            this.btnMQuery.UseVisualStyleBackColor = true;
            this.btnMQuery.Click += new System.EventHandler(this.btnMQuery_Click);
            // 
            // btnMUpdate
            // 
            this.btnMUpdate.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMUpdate.Location = new System.Drawing.Point(157, 3);
            this.btnMUpdate.Name = "btnMUpdate";
            this.btnMUpdate.Size = new System.Drawing.Size(148, 41);
            this.btnMUpdate.TabIndex = 56;
            this.btnMUpdate.Text = "修改";
            this.btnMUpdate.UseVisualStyleBackColor = true;
            this.btnMUpdate.Click += new System.EventHandler(this.btnMUpdate_Click);
            // 
            // btnMDelete
            // 
            this.btnMDelete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMDelete.Location = new System.Drawing.Point(311, 3);
            this.btnMDelete.Name = "btnMDelete";
            this.btnMDelete.Size = new System.Drawing.Size(148, 41);
            this.btnMDelete.TabIndex = 56;
            this.btnMDelete.Text = "刪除";
            this.btnMDelete.UseVisualStyleBackColor = true;
            this.btnMDelete.Click += new System.EventHandler(this.btnMDelete_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateAcc.Location = new System.Drawing.Point(465, 3);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(148, 41);
            this.btnCreateAcc.TabIndex = 56;
            this.btnCreateAcc.Text = "建立帳務";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCompany.Location = new System.Drawing.Point(593, 21);
            this.txtCompany.Multiline = true;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(156, 26);
            this.txtCompany.TabIndex = 5;
            this.txtCompany.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNo_KeyUp);
            // 
            // flowcontrol
            // 
            this.flowcontrol.Controls.Add(this.btnMAdd);
            this.flowcontrol.Controls.Add(this.btnMUpdate);
            this.flowcontrol.Controls.Add(this.btnMDelete);
            this.flowcontrol.Controls.Add(this.btnCreateAcc);
            this.flowcontrol.Controls.Add(this.btnDeleteAcc);
            this.flowcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowcontrol.Location = new System.Drawing.Point(3, 26);
            this.flowcontrol.Name = "flowcontrol";
            this.flowcontrol.Size = new System.Drawing.Size(1248, 51);
            this.flowcontrol.TabIndex = 59;
            // 
            // btnMAdd
            // 
            this.btnMAdd.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMAdd.Location = new System.Drawing.Point(3, 3);
            this.btnMAdd.Name = "btnMAdd";
            this.btnMAdd.Size = new System.Drawing.Size(148, 41);
            this.btnMAdd.TabIndex = 56;
            this.btnMAdd.Text = "新增";
            this.btnMAdd.UseVisualStyleBackColor = true;
            this.btnMAdd.Click += new System.EventHandler(this.btnMAdd_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUser.Location = new System.Drawing.Point(324, 21);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(156, 26);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNo_KeyUp);
            // 
            // plSearch
            // 
            this.plSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSearch.Controls.Add(this.lblmoney);
            this.plSearch.Controls.Add(this.lblttlamt);
            this.plSearch.Controls.Add(this.lbltitle02);
            this.plSearch.Controls.Add(this.lblaccAffairs);
            this.plSearch.Controls.Add(this.label2);
            this.plSearch.Controls.Add(this.txtNo);
            this.plSearch.Controls.Add(this.btnMQuery);
            this.plSearch.Controls.Add(this.txtCompany);
            this.plSearch.Controls.Add(this.txtUser);
            this.plSearch.Location = new System.Drawing.Point(57, 94);
            this.plSearch.Name = "plSearch";
            this.plSearch.Size = new System.Drawing.Size(1173, 73);
            this.plSearch.TabIndex = 60;
            // 
            // lblNoData01
            // 
            this.lblNoData01.AutoSize = true;
            this.lblNoData01.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData01.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNoData01.ForeColor = System.Drawing.Color.Red;
            this.lblNoData01.Location = new System.Drawing.Point(587, 482);
            this.lblNoData01.Name = "lblNoData01";
            this.lblNoData01.Size = new System.Drawing.Size(93, 27);
            this.lblNoData01.TabIndex = 58;
            this.lblNoData01.Text = "無資料";
            this.lblNoData01.Visible = false;
            // 
            // gbHolidayMgt
            // 
            this.gbHolidayMgt.Controls.Add(this.plSearch);
            this.gbHolidayMgt.Controls.Add(this.flowcontrol);
            this.gbHolidayMgt.Controls.Add(this.lblNoData01);
            this.gbHolidayMgt.Controls.Add(this.dgData);
            this.gbHolidayMgt.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbHolidayMgt.Location = new System.Drawing.Point(8, 11);
            this.gbHolidayMgt.Name = "gbHolidayMgt";
            this.gbHolidayMgt.Size = new System.Drawing.Size(1254, 526);
            this.gbHolidayMgt.TabIndex = 59;
            this.gbHolidayMgt.TabStop = false;
            this.gbHolidayMgt.Text = "收款單管理";
            // 
            // FrmRecMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 553);
            this.Controls.Add(this.gbHolidayMgt);
            this.Name = "FrmRecMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收款單";
            this.Shown += new System.EventHandler(this.FrmRecMgt_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.flowcontrol.ResumeLayout(false);
            this.plSearch.ResumeLayout(false);
            this.plSearch.PerformLayout();
            this.gbHolidayMgt.ResumeLayout(false);
            this.gbHolidayMgt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgData;
        public System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Label lblttlamt;
        private System.Windows.Forms.Label lbltitle02;
        private System.Windows.Forms.Label lblaccAffairs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNo;
        public System.Windows.Forms.Button btnMQuery;
        public System.Windows.Forms.Button btnMUpdate;
        public System.Windows.Forms.Button btnMDelete;
        public System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.FlowLayoutPanel flowcontrol;
        public System.Windows.Forms.Button btnMAdd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel plSearch;
        private System.Windows.Forms.Label lblNoData01;
        private System.Windows.Forms.GroupBox gbHolidayMgt;
    }
}