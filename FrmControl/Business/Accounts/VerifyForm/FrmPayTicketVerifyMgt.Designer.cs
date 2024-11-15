namespace JINSHIN.Finance.AccountSystem.FrmControl.Business.Accounts
{
    partial class FrmPayTicketVerifyMgt
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
            this.lblmoney = new System.Windows.Forms.Label();
            this.lblttlamt = new System.Windows.Forms.Label();
            this.lbltitle02 = new System.Windows.Forms.Label();
            this.lblaccAffairs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.btnMQuery = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.plSearch = new System.Windows.Forms.Panel();
            this.lblNoData01 = new System.Windows.Forms.Label();
            this.gbHolidayMgt = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.plSearch.SuspendLayout();
            this.gbHolidayMgt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AllowUserToDeleteRows = false;
            this.dgData.AllowUserToResizeColumns = false;
            this.dgData.AllowUserToResizeRows = false;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(18, 198);
            this.dgData.MultiSelect = false;
            this.dgData.Name = "dgData";
            this.dgData.ReadOnly = true;
            this.dgData.RowTemplate.Height = 24;
            this.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgData.Size = new System.Drawing.Size(1328, 377);
            this.dgData.TabIndex = 57;
            this.dgData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellContentClick);
            this.dgData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgData_CellFormatting);
            this.dgData.Click += new System.EventHandler(this.dgData_Click);
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
            this.lbltitle02.Text = "收款人";
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
            this.label2.Text = "收款公司";
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
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUser.Location = new System.Drawing.Point(324, 21);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(156, 26);
            this.txtUser.TabIndex = 3;
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
            this.plSearch.Location = new System.Drawing.Point(88, 29);
            this.plSearch.Name = "plSearch";
            this.plSearch.Size = new System.Drawing.Size(1173, 75);
            this.plSearch.TabIndex = 60;
            // 
            // lblNoData01
            // 
            this.lblNoData01.AutoSize = true;
            this.lblNoData01.BackColor = System.Drawing.Color.Transparent;
            this.lblNoData01.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNoData01.ForeColor = System.Drawing.Color.Red;
            this.lblNoData01.Location = new System.Drawing.Point(612, 535);
            this.lblNoData01.Name = "lblNoData01";
            this.lblNoData01.Size = new System.Drawing.Size(93, 27);
            this.lblNoData01.TabIndex = 58;
            this.lblNoData01.Text = "無資料";
            this.lblNoData01.Visible = false;
            this.lblNoData01.Click += new System.EventHandler(this.lblNoData01_Click);
            // 
            // gbHolidayMgt
            // 
            this.gbHolidayMgt.Controls.Add(this.panel1);
            this.gbHolidayMgt.Controls.Add(this.plSearch);
            this.gbHolidayMgt.Controls.Add(this.lblNoData01);
            this.gbHolidayMgt.Controls.Add(this.dgData);
            this.gbHolidayMgt.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbHolidayMgt.Location = new System.Drawing.Point(12, 10);
            this.gbHolidayMgt.Name = "gbHolidayMgt";
            this.gbHolidayMgt.Size = new System.Drawing.Size(1369, 584);
            this.gbHolidayMgt.TabIndex = 59;
            this.gbHolidayMgt.TabStop = false;
            this.gbHolidayMgt.Text = "應付票據審核";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Location = new System.Drawing.Point(88, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 75);
            this.panel1.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(31, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "付款備註";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDesc.Location = new System.Drawing.Point(127, 5);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(745, 61);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNo_KeyUp);
            // 
            // FrmPayTicketVerifyMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 592);
            this.Controls.Add(this.gbHolidayMgt);
            this.Name = "FrmPayTicketVerifyMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "應付票據管理";
            this.Shown += new System.EventHandler(this.FrmPayTicketMgt_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.plSearch.ResumeLayout(false);
            this.plSearch.PerformLayout();
            this.gbHolidayMgt.ResumeLayout(false);
            this.gbHolidayMgt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Label lblttlamt;
        private System.Windows.Forms.Label lbltitle02;
        private System.Windows.Forms.Label lblaccAffairs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNo;
        public System.Windows.Forms.Button btnMQuery;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel plSearch;
        private System.Windows.Forms.Label lblNoData01;
        private System.Windows.Forms.GroupBox gbHolidayMgt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesc;
    }
}